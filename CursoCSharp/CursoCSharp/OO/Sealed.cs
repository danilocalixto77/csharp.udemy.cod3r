using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_407_033.65;
        }
    }


    //class SouFilho : SemFilho {

    //}

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;   
        }
    }

    class Pai : Avo {
        public override sealed bool HonrarNomeFamilia() {
                return true;
        }
    }


    class FilhoRebelde : Pai {
        //public override bool HonrarNomeFamilia() {
        //    return false;
        //}
    }

    class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();

            Console.WriteLine(semFilho.ValorDaFortuna);

            FilhoRebelde filhoRebelde  = new FilhoRebelde();

            Console.WriteLine(filhoRebelde.HonrarNomeFamilia());


        }
    }
}
