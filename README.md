One repository per entity (non-generic) : This type of implementation involves the use of one repository class for each entity. For example, if you have two entities Order and Customer, each entity will have its own repository.

Generic repository: A generic repository is the one that can be used for all the entities, in other words it can be either used for Order or Customer or any other entity.

Unit Of Work: All of them will share the same instance of the DbContext
