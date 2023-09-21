https://project2ecopowersolutions.azurewebsites.net/
# CMPG323-Project3-25431285
This project is part of the CMPG323 module and focuses on various aspects of web development and software engineering, including C# programming, web development using HTML, CSS, and JavaScript, accessibility considerations, deployment to Azure with Visual Studio, and security aspects using the ASP.NET Core Identity framework.
## Training 
The training achieved for Project 3 is:
Write your first C# code badge
Build a simple website using HTML, CSS, and Javascript badge
Learn the basics of accessibility badge
Publish a wep app to Azure with Visual Studio badge
Secure a .NET web app with ASP.NET Core Identity framework badge
### Repository Folder
A Repository folder was added, wchich containts the following classes:
- GenericRepository
- iGenericRepository
- CustomersRepository
- iCustomersRepository
- ProductsRepository
- iProductsRepository
- OrderRepoaitory
- iOrdersRepository
- OrderDetailsRepository
- iOrderDetailsRepository
#### Project Structure
These are the components that the project consist of: 
 - ProductRepository Class
   Repository class for managing product-related data access.
   The meethods GetAll(): Retrieves all products from the database.

- Controller Method Index
   The Index method in the controller uses the 'ProductRepository' to retrieve and display product data.

-IGenericRepository Interface
  The Generic repository interface with common data access methods.
   - The Methods in this Class do the following:
     - GetById(int id): Retrieves an entity by its unique identifier.
     - GetAll(): Retrieves all entities of a given type.
     - Find(Expression<Func<T, bool>> expression): Finds entities based on a specified filter expression.
     - Add(T entity): Adds a new entity to the database.
     - AddRange(IEnumerable<T> entities): Adds a collection of entities to the database.
     - Remove(T entity): Removes an entity from the database.
     - RemoveRange(IEnumerable<T> entities): Removes a collection of entities from the database.

-GenericRepository Class
  The generic repository class implements the iGenericRepository interface.
  The Methods do the following: Implements all methods defined in 'IGenericRepository' for generic data access.

-iServiceRepository Interface
  Interface for managing service-related data access, extending iGenericRepository<Service>.
   - Additional Method:
     - GetMostRecentService(): Retrieves the most recently created service.

7. **ServiceRepository Class**
   - Description: Implementation of the 'IServiceRepository' interface for the service model.
   - Methods: Implements all methods from 'IGenericRepository' and includes the custom method 'GetMostRecentService()' for service-specific operations.

8. **Dependency Injection in Controller**
   - Description: The 'ServicesController' uses dependency injection to inject the 'IServiceRepository' into its constructor, enabling data access without direct context references.

9. **Implementation Instructions**
   - Description: Guidance to apply the repository pattern and dependency injection to all controller methods, replacing direct context references with repository calls.
##### Program.cs
A code for Dependence injenction was added, to cater for it.
This is the line of code of added: builder.Services.AddRazorPages();.

###### Reference List
https://www.youtube.com/watch?v=x6C20zhZHw8
https://www.youtube.com/watch?v=rsfYoA4LsS8
https://www.youtube.com/watch?v=E8QQpncP9ts
https://www.youtube.com/watch?v=-Xn7i_BcKJg
https://www.youtube.com/watch?v=BPGtVpu81ek
https://www.youtube.com/watch?v=ZEo6R8X4P4o
https://www.youtube.com/watch?v=Hhpq7oYcpGE
https://www.youtube.com/watch?v=tKEF6xaeoig
https://www.youtube.com/watch?v=CLVJVA9cTuU&list=PL4WEkbdagHIQVbiTwos0E38VghMJA06OT
https://www.youtube.com/watch?v=b0v4_Kv4_RA&list=PL4WEkbdagHIQVbiTwos0E38VghMJA06OT&index=12
https://www.youtube.com/watch?v=AYQjWE84Bjo&list=PL4WEkbdagHIQVbiTwos0E38VghMJA06OT&index=13
https://www.youtube.com/watch?v=ytSoabxSQ6E
https://www.youtube.com/watch?v=JAALTSzLx-o
https://www.youtube.com/watch?v=2b_8sXW8WfY
https://www.youtube.com/watch?v=oypz7fnb1o0
https://www.youtube.com/watch?v=qagdAYZfD04
https://www.youtube.com/watch?v=mdioesz4sXQ
https://www.youtube.com/watch?v=vdhFw1VSowg
https://www.youtube.com/watch?v=rhydGmLxfjQ
https://www.youtube.com/watch?v=rCHs9oEKKpM
https://www.youtube.com/watch?v=VFNae29uCrI
https://www.youtube.com/watch?v=tv-_1er1mWI
https://www.youtube.com/watch?v=YiVqwoFMieg
https://www.youtube.com/watch?v=9oHY5TllWaU
https://www.youtube.com/watch?v=8M7pLjacCPI

