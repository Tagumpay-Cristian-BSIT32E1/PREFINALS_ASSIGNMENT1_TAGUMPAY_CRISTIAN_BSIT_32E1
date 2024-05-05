Onion Architecture: (Yes/No) 
Have you heard of the Onion Architecture principle in software design?
  - No
  
MVC Pattern: (Yes/No) 
Are you familiar with the Model-View-Controller (MVC) pattern for building web applications?
  - No
 
Web API: (Yes/No) 
Do you understand the concept of building RESTful APIs using ASP.NET Core Web API?
  - No
 

Application & Bottlenecks:

Onion Architecture:
Benefits: (1-3 keywords)
Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability)
  - Testability - It enables unit testing at each layer independently, resulting in more robust and dependable testing methodologies, thanks to its obvious division of levels and dependencies flowing inward.
  - Better Maintainability - Maintenance is made easier with a framework that is clear and adaptable. Developers don't have to sift through irrelevant components to find and alter code linked to particular capabilities.

Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s). (e.g., Increased complexity for simple projects, difficulty finding developers familiar with the pattern)
  - Yes. I find this methodology hard because I am not familiar with it. Although this was discussed in one of the few onsite classes, it needs to be studied extensively for one individual like me to learn how to use it. By that hindrance, I encountered a lot of errors in developing the project.


MVC:
Components: (1-3 keywords each)
Briefly describe the roles of the Model, View, and Controller in the MVC pattern.
  - Model: Data, Business Logic, Persistence
  - View: User Interface, Presentation, Rendering
  - Controller: User Input Handling, Routing, Business Logic Coordination
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s). (e.g., Difficulty in unit testing controllers, logic changes rippling through the application)
  - Yes. Tight coupling between Model and Controller in MVC leads to challenges: complex unit testing due to direct interaction, increased controller complexity from mixed logic, and ripple effects from model changes impacting controllers, diminishing maintainability. Due to this challenges, I encountered a lot of errors.
 

Web API:
Differences from MVC: (Yes/No and Briefly Explain)
Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.
  - Yes. In summary, Web APIs are primarily concerned with enabling communication and data exchange between different software systems, often using lightweight data formats and stateless communication over HTTP, whereas traditional MVC applications concentrate on delivering dynamic web pages and managing user interactions.

Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If so, briefly describe the scenario(s). (e.g., Frequent page refreshes causing performance overhead, complex data exchange requiring a more lightweight approach)
  - Yes. while the simplicity and convenience of creation of classic MVC apps are among its strengths, they may encounter performance issues in situations involving frequent page refreshes and intricate data exchanges. Web APIs are preferred in many contemporary web application architectures because they provide a more efficient and lightweight method of data exchange.
