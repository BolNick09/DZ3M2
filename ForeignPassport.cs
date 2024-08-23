using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3M2
{
    public class ForeignPassport
    {
        private string number;
        private string fullName;
        private DateTime issueDate;

        public ForeignPassport(string number, string fullName, DateTime issueDate)
        {
            if (string.IsNullOrEmpty(number))
            {
                throw new ArgumentException("Номер паспорта не может быть пустым.");
            }
            if (string.IsNullOrEmpty(fullName))
            {
                throw new ArgumentException("ФИО владельца не может быть пустым.");
            }
            if (issueDate > DateTime.Now)
            {
                throw new ArgumentException("Дата выдачи паспорта не может быть в будущем.");
            }
            this.number = number;
            this.fullName = fullName;
            this.issueDate = issueDate;
        }

        public string Number
        {
            get { return number; }
        }

        public string FullName
        {
            get { return fullName; }
        }

        public DateTime IssueDate
        {
            get { return issueDate; }
        }
    }
}
