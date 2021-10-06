Hope I won't ruin your appetite

**The Game**

Let me start with a little game
This game is called pass the message. One of my favorite childhood games when I was a kid
So I grew up in an area, where people liked to gossip a bit
And you can call this game a gossip game

The objective of the game is to form a group of around 5 people
Each group forms a line
The game master then whispers a message to the first person on the line
and the person has to pass the message to the person behind
When the message reached the last person in the queue
then that person need to say the message
and the team who got the original message correctly wins

Hardly anyone wins

**Let's play**
Let's try it here

I'm going to post a message 

and then I will delete it after 5 seconds

The person who can type the exact message wins

Dont cheat!

Let's go


**What went wrong**
What did we learn from the game?

Messages can be tricky to handle

Let's examine some of the causes. 

Raise your hand if you think it's the reason why you didnt get the message 


**Computers aren't perfect**
Apparently computers, even if it's slightly better than humans, are also susceptible to making the same blunders. Sometimes the glitch is so weird, there's no way to know what happened. I feel that quite a lot with my brain

**Message Brokering and Event-Driven Architecture**
This talk is about looking into several ways we can solve this through message brokering patterns and event driven architecture, using Azure  
  

  Intro and demo of queues, service bus and event grid
- Architectural Patterns
- Design Pitfalls 

I hope I can target different levels from the audience. My demo is written in C# and Azure function

It's not a niche topic, but there are rooms for discussion and deep dives into the intricacies of messaging, if we want to maximize the highly distributed nature of the Cloud

**The Distributed Dungeon**

A distributed system is one in which the failure of a computer you didn't even know existed can render your own computer unusable.

**Simple system**

I'm sure most of you are familiar with distributed computing

If you're a developer, you have most likely built an application that's divided into several tiers. Typically there's a client, one or more services and a datastore

And the system works, by moving data from one tier to another. 

So looking at a web application

browser -> frontend -> api -> database

Seems pretty harmless right

Not quite

what if there are too many users connecting to the machine that serves the frontend 

what if the user performed several steps, and the api has to make sure that steps are processed sequentially or as a unit 

or the api couldn't  understand the format of the data that it received

or what if the machine running the database system was struck my lightning

**Test surface**

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

**Events and Messages**

So we mentioned earlier that system components communicate with each other by passing data.

There are two types of data used for such communication

Message and Events

What's the difference

**Messages** 

-indicate that something **must** happen
- contains the **essential** information to complete an action
- action can be a **command** - e.g change state, which is high-value message
- the action also changes the state of the message

**Event**

- indicate that something happen**ed**
- event ***may*** or ***may not*** trigger a reaction 
- contain reference to a relevant entity that was changed
- contain the event data or a reference for retrieving it from an event source

**What to use**

**Demo for Messages**

So let's start with the services on Azure that are made for messages. Let's dig a little bit deeper to their differences

- The good old queue


**Demo for Events**

So how about events


**The Well Architected Framework 1**
If you're using components to make sure your system is reliable and performant, then you better make sure that that service itself is reliable and performs well

Link to slide for cost, replication, availability, limits etc


**Serverless example**

If you're building applications using serverless, then you have other considerations when it comes to messaging, that is diffirent if you were building it on PaaS or containers or vm's

- Azure functions 
  - Auto-scale + max concurrency + processing time, etc
- Durable function 
- Cosmosdb

**Real World Dilemma**


**Making sense of everything**

**Final take-away**

**Closing**
And that's the end of my session
If you wish to connect, you can find me on Twitter

Shameless plug of Azure User Group Denmark, Manila and Ulap.org
















