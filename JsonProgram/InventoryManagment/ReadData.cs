

using Newtonsoft.Json;

namespace InventoryManagment
{
    public class ReadData
    {
        public InventoryDetails Read(String path)
        {
            using(StreamReader File=new StreamReader(path))
            {
                try
                {
                    String json = File.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryDetails>(json);
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
        }
    }
    
}
