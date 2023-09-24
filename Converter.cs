using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Converter
    {
        private double m_usd;
        private double m_eur;
        private double m_pln;
        //користувальницький конструктор
        public Converter(double usd, double eur, double pln)
        {
            m_usd = usd;
            m_eur = eur;
            m_pln = pln;
        }
        public double GrnToUsd (double grn)
        {
            double result = grn / m_usd;
            return result;
        }
        public double GrnToEur(double grn)
        {
            return grn / m_eur;
        }
        public double GrnToPln(double grn)
        {
            return grn / m_pln;
        }
        public double UsdToGrn(double usd)
        {
            return usd * m_usd;
        }
        public double EurToGrn(double eur)
        {
            return eur * m_eur;
        }
        public double PlnToGrn(double pln)
        {
            return pln * m_pln;
        }

    }
}
