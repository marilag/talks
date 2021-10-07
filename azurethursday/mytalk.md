# Applying Message Brokering & Event-Driven Architecture on Azure

## Abstract

The most fun part with any cloud architecture styles is seeing it in action. In this session, I'll demonstrate how we can design and implement event-driven applications on the cloud. We'll look into several building blocks, from using event modeling to communicate our specification, to implementing in-process messaging in .Net Core with the mediator pattern, and finally using Queues & Event Grid on Azure to wire things together and complete our story. 


## Outline

- Game - The gossip game
  
  - too many information to process
  - you're busy
  - you're tired
  - or maybe you're like me - I'm just getting older 
    - the other day I couldnt remember if I ate the peanut butter sandwich or not
  - 
The Problem:
  - The problem - Distributed Dungeon
    - Hard real-time system
      - request-response
    - 3-tier system
    - multiply the permutation in serverless 
    
    - Chain of requests
    - Decoupling 
    - Load balancing  and performance   
    - Resilience
    - Recovery
    - Testing!
  
The Solution:
  - Message brokering and Event driven solve many of the challenges  
  - Message vs Events 1 min
    - Commands - high value messages
    - Msg: Producer > Consumer
    - Msg: Producer > Multiple Consumers
    - Events: Producer > Multiple subscribers    
      - should it contain data all the the data
      - it can contain a resource endpoint to retrieve more data about the event
      - and return the specific about the particular event and not just to the current state of the data
      - 

The How:  
- Azure resources to use - let's break down each of them:
  
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
  - 
    - FIFO  
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
    - Solution: Service Bus Topics & Subscriptions
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
  
   Well-Architected Framework 
    
    - Operationability
      - How many queues and event grids should I make
        - depends on your application design
          - in my experience use queues to connect ologic within the scope of a feature or in ddd a bounded context
          - 
      - Telemetry correlation
      - https://docs.microsoft.com/en-us/azure/azure-monitor/app/custom-operations-tracking
    - Cost
    - Performance optimization
    - Resilience
    - Security

  
- How does messaging work with highly distirbuted platforms like serverless 
  - Durable function
  - Logic Apps
  - CosmosDB
- 
- When do I not need message queueing
  
- Tip: How do we do it?
  - Event Modeling  
  - In-process messaging 
    - Mediator pattern

- Take-away
  - A highly distributed environment like cloud 
  - Don't spread gossip!


## ToDo

- ~~Outline~~  
- ~~Demo - Simple queue~~
- ~~Demo - FIFO SB~~ 
- Demo - Transactions SB
- ~~Demo - Pub/Sub SB Topic~~
- ~~Demo - Pub/Sub Event Grid~~
- Demo - put everything together as azure durable function
- Demo - UI to display everything
- Deck - Tuesday
  - message and events diagram
  - serverless diagram
  - Comparison table
  - qr code and shortlink to github
  - twitter handle
- ~~Script - Monday~~
- Rehearsal 2 - Tuesday
- Rehearsal 3 - Wednesday
- Rehearsal 3 - Thursday
- Finish Learn module on message brokering
- Finish the book
  
## Resources:
https://docs.microsoft.com/en-us/learn/paths/architect-messaging-serverless/
https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-azure-and-service-bus-queues-compared-contrasted
https://docs.microsoft.com/en-us/azure/architecture/guide/technology-choices/messaging
https://martinfowler.com/articles/201701-event-driven.html
https://dev.to/azure/ordered-queue-processing-in-azure-functions-4h6c
https://youtu.be/vxZ_msUgZSQ
https://azure.microsoft.com/en-us/blog/a-technical-overview-of-azure-cosmos-db/
https://www.facebook.com/zuck/posts/10113957526871061
https://engineering.fb.com/2021/10/04/networking-traffic/outage/
https://docs.microsoft.com/en-us/azure/storage/common/scalability-targets-standard-account?toc=/azure/storage/blobs/toc.json




## Bio
[Link to My Photo](../cloudskwela2021/Marilag.jpg)

Marilag is a tech community leader who aims to bridge the skill gap through equal distribution of knowledge across borders, cultures & individuals. Her deep technical knowledge in Cloud and Software Engineering, combined with her relentless passion for mentorship and developer wellness, drive her to tackle the tech upskilling challenge, through her advocacy. She’s the organizer of Azure User Group Manila and AZUGDK, an Azure MVP and the co-founder of a not-for-profit group called Ulap.org. She also the tech entrepreneur behind Dewise, a cloud development company based in Copenhagen and Manila



