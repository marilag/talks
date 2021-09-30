# Applying Message Brokering & Event-Driven Architecture on Azure

## Abstract

The most fun part with any cloud architecture styles is seeing it in action. In this session, I'll demonstrate how we can design and implement event-driven applications on the cloud. We'll look into several building blocks, from using event modeling to communicate our specification, to implementing in-process messaging in .Net Core with the mediator pattern, and finally using Queues & Event Grid on Azure to wire things together and complete our story. 


## Outline

- Game - The gossip game
  
- Introduction to Message Brokering Pattern
  - Distributed Dungeon
    - Coordination
    - Decoupling 
    - Load balancing    
    - Resilience
  
  - What's Event-Driven 
  
  - Message vs Events 1 min
    - Commands - high value messages
    - Msg: Producer > Consumer
    - Msg: Producer > Multiple Consumers
    - Events: Producer > Multiple subscribers    

  
- Choosing the right Azure service for messaging 
  - Storage Queue
    - Problem: What if you need to accept large amount of requests
    - Use Case: Split a big paragraph and call the endpoint for each word
    - Solution: Azure storage queue 
    - Demo: Simple queue - demo
    - Take-away
      - Support larger messages, upto 80GB
      - Server logs 
      - At least once - handle indempotence on app as there is no built-in duplication check        
    - Notes: can use scheduling, ttl, supports poison queue
 
  - Service Bus
    - Problem: What if you need to quarantee the order of how the message is recieved
    - Use Case: Build the same paragraph
    - Solution: Service Bus - enteprise grade message broker system. Use pull - client polls  
    - Demo: FIFO on service bus
    
    - Problem: What if you need to send messages that are related to each other.
    - Use Case: All words must pass validation or the paragraph can't be created
    - Solution: Service Bus Transactions
    - Demo: Transactions 
    
    
    - Problem: What if you need several receivers of your message
    - Use Case: 2 different receivers must build the same paragraph
    - Solution: Service Bus Topics
    - Demo: Pub/Sub Service Bus   - 
    
    
    - Takeaway on Service Bus
      - Supports FIFO, Transactions and Pub/Sub
      - at most once (duplicate detection)     
      - 64 kb < 256 kb and 80 GB  
      - No server logs
  
    
  
- Choosing the right Azure service for events
  - What about events
  - Event Grid
    - Problem: What if you just want to notify another system that something happened in your system
    - Use Case: Once I created a paragraph, I need to let the audience know that the story is ready
    - Solution: Event Grid - Serverless event borker. Uses push notification style - event grid calls the client's api
    - Demo: Push paragraph to event grid and store it as blob

      Take-Away
      - Push 
      - lowcost
      - at least once - demo
      - pub/sub multiple subscribers and subscriber will get all existing events?
    
  - Event Hub - no demo just mention the use case for large amount of events e.g Logs, IoT
  

Thinkg about 5 Pillars of Architecture - Cost, Performance, Reliability, Security, Operational 
  - table of pricing model, latency, availability, security
  
- How does messaging work with highly distirbuted platforms like serverless 
  - Durable function
  - Logic Apps
  - CosmosDB
  
- Tip: How do we do it?
  - Event Modeling  
  - In-process messaging 
    - Mediator pattern

- Thanks

## ToDo

- ~~Outline~~  
- ~~Demo - Simple queue~~
- Demo - FIFO SB 
- Demo - Transactions SB
- Demo - Pub/Sub SB Topic
- Demo - Pub/Sub Event Grid
- Demo - UI to display everything
- Deck 
- Script
- Rehearsal 1
- Rehearsal 2
- Rehearsal 2
- Finish Learn module on message brokering
  
## Resources:
https://docs.microsoft.com/en-us/learn/paths/architect-messaging-serverless/
https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-azure-and-service-bus-queues-compared-contrasted
https://docs.microsoft.com/en-us/azure/architecture/guide/technology-choices/messaging
https://martinfowler.com/articles/201701-event-driven.html



## Bio
[Link to My Photo](../cloudskwela2021/Marilag.jpg)

Marilag is a tech community leader who aims to bridge the skill gap through equal distribution of knowledge across borders, cultures & individuals. Her deep technical knowledge in Cloud and Software Engineering, combined with her relentless passion for mentorship and developer wellness, drive her to tackle the tech upskilling challenge, through her advocacy. She’s the organizer of Azure User Group Manila and AZUGDK, an Azure MVP and the co-founder of a not-for-profit group called Ulap.org. She also the tech entrepreneur behind Dewise, a cloud development company based in Copenhagen and Manila



