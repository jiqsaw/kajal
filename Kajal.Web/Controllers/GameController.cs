using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LIB.ExtentionMethods;
using Kajal.Web.Models;

namespace Kajal.Web.Controllers
{
    public class GameController : BaseAuthController
    {

        public ActionResult Index()
        {
            if (session.GameSentence == null)
                GameStart();
            
            return View();
        }

        public void GameStart()
        {
            session.GameSentence = Com.GameMechanic.GetInstance().GetRandomSentence();
        }

        public PartialViewResult WordPart()
        {
            var model = Com.GameMechanic.GetInstance().NextWordPart(session.GameCurrWord);            
            return PartialView(model);
        }

        [HttpPost]
        public JsonResult CheckWord(string Word)
        {
            try
            {
                
                bool IsCorrect = (LIB.Util.r(Word).ToUpperInvariant() == session.GameCurrWord.ToUpperInvariant());
                bool EndGame = false;

                if (IsCorrect)
                {
                    if (!Com.GameMechanic.GetInstance().CheckEndGame(session.GameSentence, session.GameCurrWordIndex))
                        session.GameCurrWordIndex++;
                    else
                    {
                        session.GameClear();
                        EndGame = true;
                    }
                }

                return Json(new { result = "OK", isCorrect = IsCorrect.ToString().ToLower(), endGame = EndGame.ToString().ToLower() });
            }
            catch (Exception ex)
            {
                return Json(new { result = "ERR: " + ex.Message + " inner ex: " + ex.InnerException });
            }
        }

        public ActionResult End()
        {
            session.GameClear();
            return View();
            
        }

        public ActionResult Repeat()
        {
            session.GameClear();
            return RedirectToAction("Index", "Game");
        }

	}
}