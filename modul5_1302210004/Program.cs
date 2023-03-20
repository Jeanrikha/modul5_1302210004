using modul5_1302210004;

class Program
{
    public static void Main(string[] args)
    {
        Penjumlahan p = new Penjumlahan();
        p.JumlahTigaAngka(13.00, 02.00, 12.00);


        SimpleDataBase<int> s = new SimpleDataBase<int>();
        s.AddNewData(13);
        s.AddNewData(02);
        s.AddNewData(21);
        s.PrintAllData();

    }
}
  