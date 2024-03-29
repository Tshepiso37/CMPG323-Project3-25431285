https://project2ecopowersolutions.azurewebsites.net/
# CMPG323-Project3-25431285
Project3 is part of the CMPG323 module, consisting of 5 projects - 2 of which have already been completed, and focuses on various aspects of web development and software engineering, including C# programming, web development using HTML, CSS, and JavaScript, accessibility considerations, deployment to Azure with Visual Studio, and security aspects using the ASP.NET Core Identity framework.
## Training 
The training achieved for Project 3 is:
- Write your first C# code badge
- Build a simple website using HTML, CSS, and Javascript badge
- Learn the basics of accessibility badge
- Publish a wep app to Azure with Visual Studio badge
- Secure a .NET web app with ASP.NET Core Identity framework badge
### Repository Folder
A Repository folder was added, which containts the following classes:
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
   The Index method in the controller uses the ProductsRepository to retrieve and display product data.

- iGenericRepository Interface
   The Generic repository interface with common data access methods.
   - The Methods in this Class do the following:
     - GetById(int id): Retrieves an entity by its unique identifier.
     - GetAll(): Retrieves all entities of a given type.
     - Find(Expression<Func<T, bool>> expression): Finds entities based on a specified filter expression.
     - Add(T entity): Adds a new entity to the database.
     - AddRange(IEnumerable<T> entities): Adds a collection of entities to the database.
     - Remove(T entity): Removes an entity from the database.
     - RemoveRange(IEnumerable<T> entities): Removes a collection of entities from the database.

- GenericRepository Class
   The generic repository class implements the iGenericRepository interface.
   The Methods do the following: Implements all methods defined in iGenericRepository for generic data access.

- iServiceRepository Interface
   Interface for managing service-related data access, extending iGenericRepository<Service>.
   The GetMostRecentService() method retrieves the most recently created service.

- CustomersRepository Class
  This class implements the iCustomersRepository interface for the customer model.
  All methods are implemented from iGenericRepository and includes the custom method GetMostRecentService() for service-specific operations.
  This is applicable for the Productsrepository, OrderRepository, and OrderDetailsRepository.

- Dependency Injection in Controller
   The CustomersController uses dependency injection to inject the iCustomersRepository into its constructor, enabling data access without direct context references.
   This is applicable for the ProductsController, OrderController, and OrderDetailsController.

##### How to use the above
To utilize the repositories mentioned and their respective code:

- Implement the repository and interface classes for other models, following the pattern set for Product, Order, OrderDetails and Customers.
- Inject the appropriate repository interfaces into the controllers that require data access.
- Ensure proper configuration in the ASP.NET Core Program.cs class for dependency injection.

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

