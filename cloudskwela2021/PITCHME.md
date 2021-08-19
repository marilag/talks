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
# Agenda
- Arkitektura ng Cloud Application
- Ano ang event-driven design
- Paano magbuo ng isang cloud application 

---

# Azure Well Architected Framework

- Cost Optimization 
- Operational Excellence
- Performance
- Reliability
- Security

[Architecture Center]([htt](https://docs.microsoft.com/en-us/azure/architecture/framework/))

---

# Alamin  ang mga sumusunod

Solution:

- Anong gamit ng app
- Sino, ilan at nasaan ang mga users
- Anong timeline ng MVP at ng buong project
- Anong tech stack ang dapat gamitin

  
  
---
<!-- class:   gaia -->

# Alamin  ang mga sumusunod

Cost Optimization:

- Magkano ang budget sa MVP
- Magkano ang budget sa developers at sa infrastructure
- Pwede bang gumamit ng SaaS or third-party apps
- Pwede bang gumamit ng Open Source
- Ano ang growth plan ng project
  
---
# Alamin  ang mga sumusunod

Operational Excellence:

- Ilan ang engineers at anong skills nila
- Anong gagamitin na source repository 
- Paano magdeploy ng code at ng infrastructure  
- Paanong magkaaccess sa mga environments
- Anong mga metrics ang kailangan masubaybayan
- Anong gagawin pag nagkaroon ng problema

---
# Alamin  ang mga sumusunod

Performance:

- Gaano dapat kabilis ang response time sa normal period
- Gaano dapat kabilis sa peak period
- Anong data ang pwedeng i-cache

---
# Alamin  ang mga sumusunod

Reliability:

- Gaano katagal o kadalas pwede magdown (RTO)
- Gaano kadaming data ang pwedeng mawala (RPO)
- Anong proseso sa disaster & recovery
- Paano mamonitor ang health 
- Anong gagawin ng app sa transient error
- Anong gagawin ng app pag nagka error sa gitna ng mahabang logic

---
# Alamin  ang mga sumusunod

Security:

- Sinong pwede makaaccess ng infrastructure sa bawat environment
- Paano isetup ang network para ma control ang access sa bawat infrastructure
- Anong gagawin para madetect ang mga security threats
- Saan lalagay ang mga sensitive data
- Paano itetest ang security bago magdeploy
- Anong gamit na Identity Management at RBAC para makalogin ang users
- Saan ilalagay ang lahat ng data


---
<!-- class:   gaia -->

# Halimbawa : Eturo 
- Anong gamit ng app
  - portal para sa mga mentors at mentee
- Sino, ilan at nasaan ang mga users
  - MVP: 10 mentees, 3 mentors, 1 city 
  - Year 1: 10k mentees, 150 mentors, 3 countries
- Anong timeline ng MVP at ng buong project
  - 6 months MVP, 2 years scale-up
- Anong tech stack ang dapat gamitin
    
---

<!-- class:   gaia -->

# Ano ang Event-Driven Design



  

