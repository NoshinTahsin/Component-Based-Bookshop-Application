# Component-Based-Bookshop-Application

Created two components (two dll files) and used them in the Bookshop project and Departmental Store project.

Component 1: ClassLibraryInventory.dll checks if an ordered product is available in inventory.

Component 2: ClassLibraryShopManager.dll manages the orders via 3 operations: confirm order, update cart and send order.

# Requires Interface

The check_inventory() method from the ClassLibraryInventory component, acts as a Requires interface for the ClassLibraryShopManager component. Whenever an order needs to be confirmed, this method is required and invoked to check if the ordered item exists in the inventory.

This is how the solution explorer for the ClassLibraryShopManager component looks like after adding the ClassLibraryInventory.dll files in it.

![image](https://user-images.githubusercontent.com/35559870/151668944-02dbe4b1-5b08-4bcd-bd83-75af9e4fbcb0.png)

# Provides Interface

The ClassLibraryShopManager component provides interface for the Bookshop project and the Departmental Store project, to perform confirm_order(), update_cart() and send_order().

This is how the solution explorer for the Bookshop project looks like after adding the ClassLibraryShopManager.dll files in it.

![image](https://user-images.githubusercontent.com/35559870/151668998-c6c31bd7-597b-440d-9637-a2671023df04.png)

This is how the solution explorer for the Bookshop project looks like after adding the ClassLibraryShopManager.dll files in it.

![image](https://user-images.githubusercontent.com/35559870/151670538-9338c102-accf-4a09-b195-a3ed6fe115a1.png)

# Reusability

The components ClassLibraryInventory and ClassLibraryShopManager, are created once, and then being used by both the Bookshop and Departmental Store projects.
