namespace DBExample1;

internal class Program
{
    static void Main(string[] args)
    {
        var empAdapter = new DemoDataSetTableAdapters.EmployeeTableAdapter();
        var secAdapter = new DemoDataSetTableAdapters.SectionTableAdapter();
        var dataSet = new DemoDataSet();

        //load
        empAdapter.Fill(dataSet.Employee);
        secAdapter.Fill(dataSet.Section);

        var secRow = dataSet.Section.NewSectionRow();
        secRow.Name = "Planning";
        dataSet.Section.AddSectionRow(secRow);

        var empRow = dataSet.Employee.NewEmployeeRow();
        empRow.FirstName = "Test";
        empRow.LastName = "Last Name";
        empRow.SectionId = 1;//fixed

        dataSet.Employee.AddEmployeeRow(empRow);


        //save
        secAdapter.Update(dataSet.Section);
        empAdapter.Update(dataSet.Employee);

    }
}
