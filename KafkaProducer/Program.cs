using System.Threading.Tasks;

namespace KafkaProducer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var producer = new Producer();
            await producer.SendMessagesToCluster();
        }
    }
}
