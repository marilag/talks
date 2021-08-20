---
marp: true

---

# Cloudskwela 2021

Azure Well Architected Framework at Event-Driven Design

---

# Ako po  si Marilag Dimatulac
Founder at Chief Architect ng Dewise
Founder ng ulap.org
Organizer ng Azure User Group Manila at Denmark
Microsoft MVP sa Azure

Twitter: @marilag

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

[Architecture Center]([htt](https://docs.microsoft.com/en-us/azure/architecture/framework/))

---

## Mga dapat alamin sa produkto

:white_check_mark: Anong gamit ng applikation
:white_check_mark: Sino, ilan at nasaan ang mga users
:white_check_mark: Anong timeline ng MVP at ng buong project
:white_check_mark: Anong tech stack ang dapat gamitin

  
  
---
<!-- class:   gaia -->

## Mga dapat alamin para sa Cost Optimization:

- Magkano ang budget sa MVP
- Magkano ang budget sa developers at sa infrastructure
- Pwede bang gumamit ng SaaS or third-party apps
- Pwede bang gumamit ng Open Source
- Ano ang growth plan ng project
  
---
## Mga dapat alamin para sa Operational Excellence:

- Ilan ang engineers at anong skills meron at kailangan 
- Paano magdeploy ng code at ng infrastructure  
- Paano magkaaccess sa mga environments
- Anong mga metrics ang kailangan masubaybayan
- Anong gagawin pag nagkaroon ng problema sa production

---
# Alamin ang Performance

- Gaano dapat kabilis ang response time sa normal period
- Gaano dapat kabilis sa peak period
- Anong data ang pwedeng i-cache

---
# Alamin  ang Reliability:

- Gaano katagal o kadalas pwede magdown (RTO)
- Gaano kadaming data ang pwedeng mawala (RPO)
- Anong proseso sa disaster & recovery
- Paano mamonitor ang health 
- Anong gagawin ng app sa transient error
- Anong gagawin ng app pag nagka error sa gitna ng mahabang logic

---
# Alamin ang Security

- Sinong pwede makaaccess ng infrastructure sa bawat environment
- Paano isetup ang network para ma control ang access sa bawat infrastructure
- Anong gagawin para madetect ang mga security threats
- Saan lalagay ang mga sensitive data
- Paano itetest ang security bago magdeploy
- Anong gamit na Identity Management at RBAC para makalogin ang users
- Saan ilalagay ang lahat ng data

---
<!-- class:  lead gaia -->

# Halimbawa : Etro 


---
<!-- class:   gaia -->

# Etro 
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

# Mga Patterns at Frameworks? 

- Domain Driven Design
- Event-Driven Architecture
  

---
<!-- class: lead  gaia -->

# Ano ang Event-Driven 

---




  

