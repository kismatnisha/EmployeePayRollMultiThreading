namespace EmployeePayRollMultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeDetails> employees = new List<EmployeeDetails>();
            employees.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Eren", PhoneNumber: "8106529025", Address: "Attack On Titan", Department: "Survey Corpes", Gender: 'M', BasicPay: 25000, Deductions: 200, TaxablePay: 200, Tax: 100, NetPay: 24000, City: "shinsengumi", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Levi", PhoneNumber: "8106523333", Address: "Attack On Titan", Department: "Captian", Gender: 'M', BasicPay: 250000, Deductions: 2000, TaxablePay: 2000, Tax: 1000, NetPay: 240000, City: "Wall Maria", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 3, EmployeeName: "Mikasa", PhoneNumber: "61065629025", Address: "Attack On Titan", Department: "Survey Corpes", Gender: 'f', BasicPay: 20000, Deductions: 200, TaxablePay: 200, Tax: 100, NetPay: 19000, City: "shinsengumi", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 4, EmployeeName: "Naruto", PhoneNumber: "8123429025", Address: "Naruto", Department: "Hokage", Gender: 'M', BasicPay: 550000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 540000, City: "Leaf Village", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 5, EmployeeName: "Sasuke", PhoneNumber: "9123429025", Address: "Naruto", Department: "Shadow Hokage", Gender: 'M', BasicPay: 500000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 490000, City: "Leaf Village", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 6, EmployeeName: "Madara", PhoneNumber: "8003429025", Address: "Naruto", Department: "Uchiha Head", Gender: 'M', BasicPay: 650000, Deductions: 500, TaxablePay: 1000, Tax: 10000, NetPay: 640000, City: "Uchiha Clan", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 7, EmployeeName: "Luffy", PhoneNumber: "8123429025", Address: "OnePiece", Department: "Pirate", Gender: 'M', BasicPay: 50000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 40000, City: "Grand Blue", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 8, EmployeeName: "Zorro", PhoneNumber: "9123459025", Address: "OnePiece", Department: "Pirate Hunter", Gender: 'M', BasicPay: 40000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 40000, City: "Grand Blue", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 9, EmployeeName: "Nami", PhoneNumber: "8123429025", Address: "OnePiece", Department: "Navigator", Gender: 'F', BasicPay: 460000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 45000, City: "Grand Blue", Country: "Anime"));
            employees.Add(new EmployeeDetails(EmployeeID: 10, EmployeeName: "Naruto", PhoneNumber: "8123429025", Address: "Naruto", Department: "Hokage", Gender: 'M', BasicPay: 550000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 540000, City: "Leaf Village", Country: "Anime"));

            EmployeePayRollOperation employeePayRollOperation = new EmployeePayRollOperation();
            employeePayRollOperation.addEmployeeToParollList(employees);
        }
    }
}