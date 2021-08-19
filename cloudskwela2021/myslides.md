---
marp: true
theme: gaia
class:
  - lead
---

# Cloudskwela 2021

Event Driven Application with Azure Well Architected Framework

---

# Ako po  si Marilag Dimatulac
Founder at Chief Architect ng Dewise
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

# Alamin ang Solution

- Anong gamit ng app
- Sino, ilan at nasaan ang mga users
- Anong timeline ng MVP at ng buong project
- Anong tech stack ang dapat gamitin

  
  
---
<!-- class:   gaia -->

# Alamin Cost Optimization:

- Magkano ang budget sa MVP
- Magkano ang budget sa developers at sa infrastructure
- Pwede bang gumamit ng SaaS or third-party apps
- Pwede bang gumamit ng Open Source
- Ano ang growth plan ng project
  
---
# Alamin ang Operational Excellence:

- Ilan ang engineers at anong skills nila
- Anong gagamitin na source repository 
- Paano magdeploy ng code at ng infrastructure  
- Paanong magkaaccess sa mga environments
- Anong mga metrics ang kailangan masubaybayan
- Anong gagawin pag nagkaroon ng problema

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

# Halimbawa : Eturo 


---
<!-- class:   gaia -->

# Eturo 
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




  

