Good evening! Hope you're this meetup so far, and perhaps your dinner! I hope I'm not ruining your appetite

Thanks for having me here at Azure Thursday. My name is Marilag and I'm a tech and social entrepreneur at Dewise

Im an Azure cloud solution architect and a .net developer since I was about 17

You can find me on Twitter but I'm not really a good a twitting



**The Game** 02

Let me start with a little game

I call it the Gossip game. We played it a lot as kids in the Philippines. Maybe you also played it here in The Netherlands

The idea is that the game master passes the message to the first player, who will then forward it to the next person and so on. The last person on the queue needs to say the message out loud. The team who got the correct message wins.

Which hardly ever happens, therefor it's called gossip game. 


**Let's play** 04

Let's try it here

I'm going to post a message on screen

and then I will delete it after 5 seconds

If you want to participate, remember as much as you can an post the story on the chat

Later, after my talk, I'll find the one who got the closest to reality and give you a price

Dont cheat!

Let's start

Did anybody win?

**What went wrong** 05

What did we learn from the game?

Messages can be tricky to handle

Let's examine some of the causes. 

Insufficient memory. They say an average person can keep about 4 items in its short term memory within 30 seconds

Maybe it's too much information

We can remember 7 words at a time

Person, woman, man, camera, TV :D

Maybe you were sleepy

Or you're busy watching squid game and not paying attention to this talk - which is fine :)


**Computers aren't perfect** 06

Apparently computers, even if it's slightly better than humans, are also susceptible to making the same blunders. 

Sometimes the glitch is so weird, there's no way to know what happened. Like the other day - I could not remember whether I ate the peanut butter sandwich or not.

**Message Brokering and Event-Driven Architecture** 06

This talk is about looking into several ways to address these physical system limitations,  through message brokering patterns and event driven architecture, using Azure  
  

- Intro and demo of queues, service bus and event grid
- Architectural Patterns
- Design Pitfalls 

My demo is written in C# and Azure function

I know this is not a niche topic, messaging has been around in Azure for a long time. But I still encounter engineers having challenges with picking the tool for their distirbuted applications

**The Distributed Dungeon** 07

Have you ever find yourself lost in the distributed dungeon? I have...

This quote from Leslie Lampert describes that situation

A distributed system is one in which the failure of a computer you didn't even know existed can render your own computer unusable.

**Simple system** 07

Most of us have only worked with distributed system, apart from the few her - don't be ashamed to admit

If you're a developer, you have most likely built an application that's divided into several tier

And the system works, by moving data from one tier to another. 

So looking at a web application

browser -> frontend -> api -> database

Seems pretty harmless right

Not quite

what if there are too many users connecting to the machine 

of that you need to process their input in correct sequence

what if the api couldn't  understand the format of the data that it received

or what if your database exploded


**Test surface** 08

Suddenly our simple system, becomes a little too needy for attention

Suddenly we need to handle all these what-if's at each layer of our solution

Including the what-if the error is unknown

So our test surface becomes larger in a distributed system

And this multiplies in a microservice setup

We have to handle

Reliability
Performance
Security
Operationability
Maintainability
Cost

For now, let's focus on achieving two things Reliability and Performance, through message brokering and event-driven architecture

**Events and Messages** 10

So we mentioned earlier that system components communicate with each other by passing data.

There are two types of data used for such communication

Message and Events

What's the difference

**Messages** 10

-indicate that something **must** happen
- contains the **essential** information to complete an action
- action can be a **command** - e.g change state, which is high-value message
- the action also changes the state of the message

**Event** 10

- indicate that something happen**ed**
- event ***may*** or ***may not*** trigger a reaction 
- contain reference to a relevant entity that was changed
- contain the event data or a reference for retrieving it from an event source

If the event was triggered by a state change, it's probably interesting for subscribers to know that specific state of the entity when the evetn occurred, vs directly linking to the entity and see it's current state, which may not be the result of the event that was just received


**Demo for Queues** 25

***Azure queue***

    - Problem: What if you need to accept large amount of requests and you want to do load balancing and load leveling  
    - Use Case: Split a big paragraph and call the endpoint for each word
    - Steps:
      - Show Portal
      - Call Api
      - Display the message
      - Show th code
    - Observe
      - Message not always in order
      - Message is at least once but can me more

    - Take-away
      - Support larger messages, upto 80GB
      - Server logs 
      - Can use scheduling, ttl
      - Supports poison queue

***Service Bus***

    FIFO

    - Problem: What if you need to quarantee the order of how the message is recieved
    - Use Case: Build the same paragraph    
    - Demo: FIFO on service bus
    - Steps:
      - Show Portal
      - Call Api
      - Display the message
      - Show th code 
    
    TRANSACTION

    - Problem: What if you need to send messages that are related to each other.
    - Use Case: All words must pass validation or the paragraph can't be created
    - Steps:
      - Show Portal
      - Call Api
      - Display the message
      - Show th code 
    
    TOPICS and SUBSCRIPTIONS
    
    - Problem: What if you need several receivers of your message
    - Use Case: 2 different receivers must build the same paragraph
    - Steps:
      - Show Portal
      - Call Api
      - Display the message
      - Show th code 
    - Observation:
      - Topics create sub queues which functions as regular queue
      - Subscribers connect to sub queues 
    
    DEAD-LETTERING

    - Problem: What if you need to handle invariance within your application
    - Use Case: 1 susbcriber sends the message to dead letter
    - Demo: Pub/Sub Service Bus   
      - Call Api
      - Display the message
      - Show th code 
    - Obeservations:
      - Each subscription ahs its own deadleatter not the topic
      - Queues can automation send a message to dead letter if you turn it on for ttl
      - DLQ message has no ttl, it stays there until it's proccessed and completed

    - Takeaway on Service Bus
      - Supports FIFO, Transactions and Pub/Sub
      - at most once (duplicate detection)     
      - 64 kb < 256 kb and 80 GB  
      

**Demo for Event Grid** 30

    - Problem: What if you just want to notify another system that something happened in your system
    - Use Case: Once I created a paragraph, I need to let the audience know that the story is ready
    - Solution: Event Grid - Serverless event borker. Uses push notification style - event grid calls the client's api
    - Demo: Push paragraph to event grid and store it as blob

      Take-Away
      - Push notification style
      - 24 hour retry with exponential back off      
      - at least once - demo
      - dead-lettering on storage blob
      - if blob storage is unavailable it will drop the event



**FAQs** 30

- When should I use queue? 
- What's the difference between the services?
- How about event hub?
- What's the pricing model?
- Disaster recovery


**Serverless Sanctuary** 35

- Self-service digital product creation 
  
  This is one of the architecture we're using for a customer project. Unfortunately I'm not allowed to show the solution and the code but I can talk about the Architecture
  
  The system is a self-service portal for cloud engineers in an enterprise

  This design implements part of a workflow for onboardin a new digital product

  A bunch of things need to happend before it's completed

  So from a technical perspective, it's not so different implementing any workdlow for handling the lifecycle of any entity

  We start with a call from the User
  
  Since it's a long running process, that can possibly span days due to an approval, we implemented it as a durable function

  The orchestraot triggers the first activity which creates the domain entity in the database

  then it triggers the waiting for approval and will continue as soon it is approved. There's an expiration

  Then after the approval, there are just a series of steps to execute, create ad groups, create resources, assign groups to resources, update the entity's state

  When all the steps haave succeeded, the orchestration completes and everyone is happy

  Let's examine a few architectural elements here

  We put a queue between the client and function to manage the load for the orchestration 

  Each activity are command handlers

  When the command succeeds, it publishes an internal event, captured by an internal handler that triggers the next activity, hence command

  This uses in-process message brokering with the mediator pattern

  If we need to triggers several parallel activities we simply subscribe multuple handlers (internally) for same event that can invoke multiple commands

  We also store every internal event in an event store later for logging or other business logic

  If an error occurs in any of the command handling, we handle that error, which checks where in the process you are, retry, roll-back or move forward depending on the scenario

  If it's a fatal error, we close the orchestration 

  If you notice, we expose the individual activities as an api, so it can also be retriggered on another session, if necessary. In case of recovering from a fatal error

  If things are successful, the orchestration completes and trigger a final internal event notification. The handler then publishes an external notification posted on Event Grid where other bounded context from different services are subscribed

  

**Design Pitfalls** 36

- Remember all the Architectural Pillars 
  - Performance, Reliability, Cost, Operationability, Security
- Queue of queues 
  - limit system boundaries to a level that a normal human being can track
  - catalog api's and event sources
- Tracing
  - Distributed tracing in app insight
  - You can also write your own logs 



**Devteam Toolbox** 38

We use event modeling - link
We use mediator pattern

**Final take-away** 40

**Closing**
And that's the end of my session
If you wish to connect, you can find me on Twitter

Shameless plug of Azure User Group Denmark, Manila and Ulap.org
















