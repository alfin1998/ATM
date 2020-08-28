using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM {
    class Nasabah {
        private String fname;
        private String lname;
        private Rekening rekening;

        public Nasabah(Rekening mRekening, string mfname, string mlname) {
            this.mRekening = mRekening;
            this.fname = mfname;
            this.lname = mlname;
            
        }

        public Rekening mRekening {
            get { return rekening; }
            set { rekening = value; }
        }

        public String mlname {
            get { return lname; }
            set { lname = value; }
        }

        public String mfname {
            get { return fname; }
            set { fname = value; }
        }
    }
}
