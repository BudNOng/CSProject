using System;
using System.Collections.Generic;
using System.Text;

namespace CSProject
{
    class Admin : Staff
    {
        private const float _overtimeRate = 15.5f;
        private const float _adminHourlyRate = 30;

        public float Overtime { get; private set; }
        public int OvertimeHours { get; private set; }

        public Admin(string name): base(name, _adminHourlyRate)
        {

        }

        public override void CalculatePay()
        {
            base.CalculatePay();

            if (HoursWorked > 160)
            {
                OvertimeHours = HoursWorked - 160;
                float Overtime = _overtimeRate * (HoursWorked - 160);

                TotalPay = TotalPay + Overtime;
            }
        }

        public override string ToString()
        {
            return "\nChild constructor - This is Object of Admin, " + NameOfStaff +
                ",\nwith hourly rate of " + _adminHourlyRate + "/hour -" +
                "\nthis manager have worked for " + HoursWorked + " hours" +
                "\nTotal pay for this Manager Staff is " + TotalPay +
                "\n================= END =================";
        }
    }
}
