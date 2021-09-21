using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumbProject
{
    class SoPhuc
    {
        private double phanThuc {set; get;}
        private double phanAo { set; get; }
        public SoPhuc(double phanThuc, double phanAo)
        {
            this.phanThuc = phanThuc;
            this.phanAo = phanAo;
        }
        public SoPhuc cong(SoPhuc khac)
        {
            return new SoPhuc(phanThuc + khac.phanThuc, phanAo + khac.phanAo);
        }
        public SoPhuc tru(SoPhuc khac)
        {
            return new SoPhuc(phanThuc - khac.phanThuc, phanAo - khac.phanAo);
        }
        public SoPhuc nhan(SoPhuc khac)
        {
            double phanThucKq = phanThuc * khac.phanThuc - phanAo * khac.phanAo;
            double phanAoKq = phanThuc * khac.phanAo + khac.phanThuc * phanAo;
            return new SoPhuc(phanThucKq, phanAoKq);
        }
        public SoPhuc chia(SoPhuc khac)
        {
            double mau = khac.phanThuc * khac.phanThuc + khac.phanAo * khac.phanAo;
            double phanThucKq = (phanThuc * khac.phanThuc + phanAo * khac.phanAo);
            double phanAoKq = (-phanThuc * khac.phanAo + phanAo * khac.phanThuc);
            return new SoPhuc(phanThucKq / mau, phanAoKq / mau);
        }
    }
}
