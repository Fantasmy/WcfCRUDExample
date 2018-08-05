using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceApp
{
    public static class Converter
    {
        public static WcfDto ConvertWCFtoWCFDTO(Students obj)
        {
            WcfDto objdto = new WcfDto();
            objdto.id = obj.id;
            objdto.name = obj.name;
            objdto.surname = obj.surname;
            objdto.email = obj.email;
            return objdto;
        }

        public static Students ConvertWCFDTOtoWCF(WcfDto obj)
        {
            Students objdto = new Students();
            objdto.id = obj.id;
            objdto.name = obj.name;
            objdto.surname = obj.surname;
            objdto.email = obj.email;
            return objdto;
        }
    }
}