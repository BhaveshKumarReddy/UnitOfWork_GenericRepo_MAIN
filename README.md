One repository per entity (non-generic) : This type of implementation involves the use of one repository class for each entity. For example, if you have two entities Order and Customer, each entity will have its own repository.

Generic repository: A generic repository is the one that can be used for all the entities, in other words it can be either used for Order or Customer or any other entity.

Unit Of Work: All of them will share the same instance of the DbContext

![alt text](https://f4n3x6c5.stackpathcdn.com/UploadFile/b1df45/unit-of-work-in-repository-pattern/Images/Repository%20Pattern1.jpg)
