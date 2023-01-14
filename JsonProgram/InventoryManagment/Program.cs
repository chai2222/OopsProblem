namespace InventoryManagment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String path = "D:\\C Sharp\\JsonProgram\\InventoryManagment\\Inventory.json";
            ReadData readdata = new ReadData();
            var data = readdata.Read(path);

            //Console.WriteLine(data..Name);
            Console.WriteLine(data.typeofrice.Weigth);
            Console.WriteLine(data.typeofrice.Price);
        }
    }
}
