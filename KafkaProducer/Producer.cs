using System;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace KafkaProducer
{
    class Producer
    {
        private static readonly ProducerConfig config = new ProducerConfig
        { BootstrapServers = "localhost:9092" };
        private static string topic = "f_topic";

        public async Task SendMessagesToCluster()
        {
            string key = "1";
            string value = "mess";
            using (var producer = new ProducerBuilder<string, string>(config).Build())
            {
                try
                {
                    await producer.ProduceAsync(topic,
                        new Message<string, string> { Key = key, Value = value });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
