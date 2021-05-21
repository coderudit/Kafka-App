# Kafka-App
Kafak app with a producer and a consumer.

1. We are using docker compose as we need to run 2 services one is zookeeper and other is
   kafka.
2. Create a docker-compose.yml file
   version: "3"
   services:
	zookeeper:
	    	image: wurstmeister/zookeeper
                container_name: zookeeper
 		ports: 
		- "2181:2181"
	kafka:
		image: wurstmeister/kafka
		container_name: kafka
		ports: 
		- "9092:9092"
	environment:
		KAFKA_ADVERTISED_HOST_NAME: localhost
		KAFKA_CREATE_TOPICS: "f_topic:1:1"
		KAFKA_ZOOKEEPER_CONNECT: zookeeper
	


docker-compose -f docker-compose.yml up: To run in the foreground mode
docker-compose -f docker-compose.yml up -d: To run in the background mode
docker-compose down
docker exec -it kafka /bin/sh
cd /opt
cd /kafka
kafka-console-producer.sh --broker-list localhost:9092 --topic f_topic
kafka-console-consumer.sh --bootstrap-server localhost:9092 --topic f_topic

https://dzone.com/articles/running-apache-kafka-on-windows-os
https://www.youtube.com/watch?v=WnlX7w4lHvM
https://www.red-gate.com/simple-talk/dotnet/net-development/using-apache-kafka-with-net/
