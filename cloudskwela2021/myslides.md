---
marp: true

---
<!-- _color: white -->
![bg ](cloudskwela2021.jpg)


---
![bg right:35%](Marilag.jpg)
# Ako po  si Marilag 
:blue_heart: Founder at Chief Architect ng [Dewise](https://www.dewise.com/)
:cloud: Founder ng ulap.org
:green_heart: Organizer ng Azure User Group MNL at DK
:computer: Microsoft MVP sa Azure

Twitter: @marilag

---
<!--  _backgroundColor: white -->
## Event-Driven Application at  Azure Well Architected Framework  

---
<!-- class:  gaia -->
# Layunin
- Arkitektura ng Cloud Application  
- Ano ang event-driven design
- Halimbawa ng pagbuo ng isang cloud application 

---

# Azure Well Architected Framework

- Cost Optimization 
- Operational Excellence
- Performance
- Reliability
- Security

[https://docs.microsoft.com/en-us/azure/architecture/framework/](https://docs.microsoft.com/en-us/azure/architecture/framework/)

---

## Mga dapat alamin sa produkto

:white_check_mark: Anong gamit ng applikation
:white_check_mark: Sino, ilan at nasaan ang mga users
:white_check_mark: Anong timeline ng MVP at ng buong project
:white_check_mark: Anong tech stack ang dapat gamitin

  
  
---
<!-- class:   gaia -->

## Mga dapat alamin para sa Cost Optimization:

  :white_check_mark: Magkano ang budget sa MVP
  :white_check_mark: Magkano ang budget sa developers at sa infrastructure
  :white_check_mark: Pwede bang gumamit ng SaaS or third-party apps
  :white_check_mark: Pwede bang gumamit ng Open Source
  :white_check_mark: Ano ang growth plan ng project
  
---
## Mga dapat alamin para sa Operational Excellence:

  :white_check_mark: Ilan ang engineers at anong skills meron at kailangan 
  :white_check_mark: Paano magdeploy ng code at ng infrastructure  
  :white_check_mark: Paano magkaaccess sa mga environments
  :white_check_mark: Anong mga metrics ang kailangan masubaybayan
  :white_check_mark: Anong gagawin pag nagkaroon ng problema sa production

---
# Mga dapat alamin para sa Performance

  :white_check_mark: Gaano dapat kabilis ang response time sa normal period
  :white_check_mark: Gaano dapat kabilis sa peak period
  :white_check_mark: Anong data ang pwedeng i-cache

---
# Mga dapat alamin para sa Reliability:

  :white_check_mark: Gaano katagal o kadalas pwede magdown (RTO)
  :white_check_mark: Gaano kadaming data ang pwedeng mawala (RPO)
  :white_check_mark: Anong proseso sa disaster & recovery
  :white_check_mark: Paano mamonitor ang health 
  :white_check_mark: Anong gagawin ng app sa transient error
  :white_check_mark: Anong gagawin ng app pag nagka error sa gitna ng mahabang logic

---
# Mga dapat alamin para sa Security

  :white_check_mark: Sinong pwede makaaccess ng infrastructure sa bawat environment
  :white_check_mark: Paano isetup ang network para ma control ang access sa bawat infrastructure
  :white_check_mark: Anong gagawin para madetect ang mga security threats
  :white_check_mark: Saan lalagay ang mga sensitive data
  :white_check_mark: Paano itetest ang security bago magdeploy
  :white_check_mark: Anong gamit na Identity Management at RBAC para makalogin ang users
  :white_check_mark: Saan ilalagay ang lahat ng data

---
<!-- class:  lead gaia -->

# Halimbawa : Etro App

---
<!-- class:   gaia -->

# Etro App
- Anong gamit ng app? 
  - Portal para sa mga mentors at mentee
- Sino, ilan at nasaan ang mga users
  - MVP: 10 mentees, 3 mentors, 1 city 
  - Year 1: 10k mentees, 150 mentors, 3 countries
- Anong timeline ng MVP at ng buong project
  - 6 months MVP, 2 years scale-up
- Anong tech stack ang dapat gamitin
  - Containers + Serverless, .Net, C#, CosmosDB, Messaging    
---

# Mga paraan na may kaugnayan sa pagdisenyo ng Event-Driven Application

- Domain Driven Design
- Microservices
- CQRS
- Message Brokering
- Events Publishing / Subscription 
- Event Modeling

---
<!-- class: lead  gaia -->

# Demo: Event-Driven gamit ang mga sumusunod
- .Net Core at Azure Functions para sa mga APIs
- Mediator pattern para sa in-process message brokering
- Storage queues para sa remote message brokering
- Event grid para sa pub/sub event routing
---

# Mga dapat tandaan
- Paghandaan ang bawat proyekto gamit ang Azure Well Architected Framework
- Huwag malunod sa patterns
- Bawat problema ay magkakaiba


  

