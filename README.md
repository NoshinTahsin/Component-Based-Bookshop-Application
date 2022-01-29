# Component-Based-Bookshop-Application

Implemented a component-based software using .NET, which supports reuse. 

# Steps for Project Execution

Step 1: This project is done using .NET 5.0. To run this application, .NET is needed to be installed on your computer. 
Step 2: Start Visual Studio (I have used Visual Studio 2019) and open the Bookshop.sln to run the Bookshop Application. Open the DepartmentalStore.sln, if you want to run the Departmental Store Application instead. Both of the applications use the same components I have created. I have shown two different projects using the same component to demonstrate component reusability. 
Step 3: From the top bar of Visual Studio, click the Run button to run the application
Step 4: You will see the output on the console

# Project Description

Components work as a provider of one or more services. When a system needs something to be done, it calls a component to provide that desired service without caring about where that component is executing or the programming language used to develop the component. 

I have created two components (two .dll files), ClassLibraryInventory.dll and ClassLibraryShopManager.dll, then used them both in the Bookshop project and DepartmentalStore project.

When called by the project Bookshop or DepartmentalStore, the component ClassLibraryInventory.dll checks if an ordered product is available in inventory. The component ClassLibraryShopManager.dll manages the orders through performing these 3 operations, when called: confirm_order(), update_cart(), and send_order().

# Component Interfaces

A reusable component has two critical characteristics. The component is an independent executable entity that is defined by its interfaces. We don’t need any knowledge of its source code to use it. It can be included directly in a program. The services offered by a component are made available through an interface, and all interactions are through that interface. The component interface is expressed in terms of parameterized operations, and its internal state is never exposed. 
In principle, all components have two related interfaces that reflect the services that the component provides and the services that the component requires to operate correctly: 

Provides Interface: The “provides” interface, that defines the services provided by the component and defines the methods that can be called by a user. In this case, the ClassLibraryShopManager component provides interfaces for the Bookshop project and the DepartmentalStore project, to perform confirm_order(), update_cart() and send_order().

This is how the solution explorer for the Bookshop project looks like after adding the ClassLibraryShopManager.dll file in it.

![image](https://user-images.githubusercontent.com/35559870/151668998-c6c31bd7-597b-440d-9637-a2671023df04.png)

This is how the solution explorer for the DepartmentalStore project looks like after adding the ClassLibraryShopManager.dll file in it.

![image](https://user-images.githubusercontent.com/35559870/151670538-9338c102-accf-4a09-b195-a3ed6fe115a1.png)

Requires Interface: The “requires” interface specifies the services that other components in the system must provide if a component is to operate correctly. If these services are not available, then the component will not work. The check_inventory() method from the ClassLibraryInventory component, acts as a Required interface for the ClassLibraryShopManager component. Whenever an order needs to be confirmed, the method check_inventory() is required and invoked to check if the ordered item exists in the inventory.

![image](https://user-images.githubusercontent.com/35559870/151668944-02dbe4b1-5b08-4bcd-bd83-75af9e4fbcb0.png)

# Demonstration of Reusability

Suppose, we have a bookshop that sells books to the customers online. Their business is managed by software. They need a shop management component for their software, that will handle orders from customers, update carts and deliver products (books in this case). Again, we have a departmental store that sells goods to the customers. They also manage their business through software, and need a shop management component that will handle orders from customers, update carts and deliver products (daily goods in this case). I have created two components, ClassLibraryInventory and ClassLibraryShopManager, for this purpose. 

The components are created once, and then used by both the Bookshop and DepartmentalStore projects. Each of the projects just needs to add the components in their respective applications and call those components to perform the desired tasks. That is, the components are reusable. 

# Resources Used

1. Chapter 16, Software Engineering 10th Edition by Ian Sommerville
2. https://dev.to/towernter/how-to-create-a-dynamic-link-library-dll-and-use-it-in-net-and-python-31oo
