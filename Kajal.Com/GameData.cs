using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kajal.Com
{
    public class GameData
    {
        public static List<string> Sentences = new List<string>{

                "12 SAAT KALICI GÜZELLİK",
                "DİĞER GÜZELLİK CÜMLESİ",
                "UCUNCU CUMLE BURADA"
        };

        // { WORD, DISPLAYNAME, VIDEOCODE, FAKEWORDS... }
        public static Dictionary<string, string> Words = new Dictionary<string, string> {

                { "w01",        "w01, w01Y               | 4FKYsUEuvIo   | w02, w03, w04, w05, w06, w07, w08, w09, w010          | " },
                { "GÜZELLİK",   "GÜZELLİK, GÜZELDİR      | 4FKYsUEuvIo   | w12, w13, w14, w15, w16, w17, w18, w19, w110          | " },
                { "w21",        "w21, w21 Y              | 4FKYsUEuvIo   | w22, w23, w24, w25, w26, w27, w28, w29, w210          | " },
                { "SAAT",       "SAAT, SAATY             | 4FKYsUEuvIo   | w32, w33, w34, w35, w36, w37, w38, w39, w310          | " },
                { "DİĞER",      "DİĞER, DİĞERY           | 4FKYsUEuvIo   | W42, w43, w44, w45, w46, w47, w48, w49, w410          | " },
                { "w51",        "w51, w51Y               | 4FKYsUEuvIo   | w52, w53, w54, w55, w56, w57, w58, w59, w510          | " },
                { "12",         "12, 12Y                 | 4FKYsUEuvIo   | w62, w63, w64, w65, w66, w67, w68, w69, w610          | " },
                { "w71",        "w71, w71Y               | 4FKYsUEuvIo   | w72, w73, w74, w75, w76, w77, w78, w79, w710          | " },
                { "KALICI",     "KALICI, KALICIY         | 4FKYsUEuvIo   | w82, w83, w84, w85, w86, w87, w88, w89, w810          | " },
                { "CÜMLESİ",    "CÜMLESİ, CÜMLESİY       | 4FKYsUEuvIo   | w92, w93, w94, w95, w96, w97, w98, w99, w910          | " },
                { "w101",       "w101, w101Y             | 4FKYsUEuvIo   | w102, w103, w104, w105, w106, w107, w108, w109, w1010 | " },
                { "CUMLE",      "CUMLE, CUMLEY           | 4FKYsUEuvIo   | w112, w113, w114, w115, w116, w117, w118, w119, w1110 | " },
                { "UCUNCU",     "UCUNCU, UCUNCUY         | 4FKYsUEuvIo   | w122, w123, w124, w125, w126, w127, w128, w129, w1210 | " },
                { "w131",       "w131, w131Y             | 4FKYsUEuvIo   | w132, w133, w134, w135, w136, w137, w138, w139, w1310 | " },
                { "BURADA",     "BURADA, BURADAY         | 4FKYsUEuvIo   | w142, w143, w144, w145, w146, w147, w148, w149, w1410 | " },
                { "w151",       "w151, w151Y             | 4FKYsUEuvIo   | w152, w153, w154, w155, w156, w157, w158, w159, w1510 | " } 

        };

    }
}