using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Employee
    {
        //SINGLE RESPONSIBLITY=> her sınıf / metod tek sorumluluğa hizmet etmeli yani değişmesi için tek bir nedeni olmalı
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TCno { get; set; }
        public bool AddEmployee(Employee employee)
        {
            return true;
            //işlemlerin yapıldığı düşünüldüğünde
        }

        //public void CreateReport(Employee employee)
        //{
        //    // x formatta çıktı vererek çalışan bilgilerini rapor eden metot.
        //    // ama x formatta çıktı (pdf, xml, json, excel,...) olabilir ve değişmek istendiğinde yada rapor vermenin başka sınıflar tarafında da kullanılması gerektiğinde burada değişkenler yapmak ve sorumluluk aşılmış olacak ve bu metodun değişimi tek bir nedene dayalı olmayacak. Bu yüzden aslında bu metodun başka bir sınıfa yerleştirilmesi ve employee nin bu sınıfla çalışması daha mantıklı ki metod diğer sınıflara da hizmet edebilsin.

        //    // rapor vermek daha genel. ayrıca bugün xml verebilirim ama yarın pdf jpg isteyebilirler.
        //}
    }

    public class Kontrol
    {
        public void CreateReport(Employee employee)
        {
            // x formatta çıktı vererek çalışan bilgilerini rapor eden metot.
            // ama x formatta çıktı (pdf, xml, json, excel,...) olabilir ve değişmek istendiğinde yada rapor vermenin başka sınıflar tarafında da kullanılması gerektiğinde burada değişkenler yapmak ve sorumluluk aşılmış olacak ve bu metodun değişimi tek bir nedene dayalı olmayacak. Bu yüzden aslında bu metodun başka bir sınıfa yerleştirilmesi ve employee nin bu sınıfla çalışması daha mantıklı ki metod diğer sınıflara da hizmet edebilsin.

            // rapor vermek daha genel. ayrıca bugün xml verebilirim ama yarın pdf jpg isteyebilirler.
        }
    }
}
