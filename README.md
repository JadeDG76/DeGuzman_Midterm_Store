# DeGuzman Midterm Store

## Simple E-Commerce Website

This project is a simple online store made for our midterm project.

The website lets users view products, search products, add products to a cart, and manage the cart.

It also lets the user add, edit, and delete products.

---

## Project Information

**Project Name:** DeGuzman Midterm Store

**Language:** C#

**Framework:** ASP.NET Core MVC

**Database:** SQLite

**Database Tool:** Entity Framework Core

**Platform:** GitHub Codespaces

**Version Control:** GitHub

---

## What This Website Can Do

The website can:

* Add products
* Show products
* Edit products
* Delete products
* Search products
* Add products to cart
* Change cart quantity
* Remove products from cart
* Show the total price

---

## Product

Each product has:

* ID
* Name
* Description
* Price
* Category

The product page shows all the products in the store.

There is also a search bar that can search by product name or category.

---

## Product CRUD

The website has CRUD.

CRUD means:

* **Create** - Add a product
* **Read** - View products
* **Update** - Edit a product
* **Delete** - Delete a product

The user can manage the products using the Product page.

---

## Shopping Cart

The website has an Add to Cart button.

When the user clicks **Add to Cart**, the product is added to the cart.

The quantity starts at 1.

If the same product is added again, the quantity will increase.

The Cart page shows:

* Product Name
* Price
* Quantity
* Total

The user can also update the quantity or remove the item.

The total price is:

```text
Price × Quantity
```

---

## Database

The project uses SQLite.

The database file is:

```text
store.db
```

There are two main tables:

### Products

The Products table saves the product information.

* Id
* Name
* Description
* Price
* Category

### CartItems

The CartItems table saves the products added to the cart.

* Id
* ProductId
* ProductName
* Price
* Quantity

---

## Project Files

The project uses the MVC structure.

```text
Controllers
    CartController.cs
    HomeController.cs
    ProductController.cs

Data
    ApplicationDbContext.cs

Models
    Product.cs
    CartItem.cs

Views
    Cart
    Home
    Product
    Shared

wwwroot
    css
    js

Program.cs
appsettings.json
store.db
```

---

## Important Files

### Product.cs

This is the model for the products.

It contains the product name, description, price, and category.

### CartItem.cs

This is the model for the shopping cart.

It saves the product and its quantity.

### ApplicationDbContext.cs

This connects the project to the database.

### ProductController.cs

This controls the product page.

It handles:

* Create
* Read
* Edit
* Delete
* Search

### CartController.cs

This controls the cart.

It handles:

* Add to Cart
* Update Quantity
* Remove Item
* Cart Page

### Program.cs

This is where the main project settings are placed.

It also connects the project to SQLite.

### appsettings.json

This contains the database connection.

```text
Data Source=store.db
```

---

## Navigation Bar

The website has a navigation bar.

It has:

* Products
* Cart

This makes it easy to move between the pages.

---

## Design

The website has a simple and clean design.

It uses:

* Product cards
* Buttons
* Forms
* Search bar
* Navigation bar
* Cart table

The design is made to be simple and easy to use.

---

## How the Website Works

The basic flow is:

```text
Open Website
     ↓
View Products
     ↓
Search Product
     ↓
Add to Cart
     ↓
Open Cart
     ↓
Change Quantity
     ↓
View Total
```

For managing products:

```text
Product Page
     ↓
Create
     ↓
Read
     ↓
Edit
     ↓
Delete
```

---

## How to Run

Open the project in GitHub Codespaces.

Open the terminal and use these commands.

### Restore

```bash
dotnet restore
```

### Build

```bash
dotnet build
```

### Run

```bash
dotnet run
```

After running the project, open the link given by the terminal.

---

## Testing

I tested the main features of the website.

* [x] Product page
* [x] Search
* [x] Create Product
* [x] Edit Product
* [x] Delete Product
* [x] Add to Cart
* [x] Update Quantity
* [x] Remove Item
* [x] Cart Total
* [x] Navigation Bar
* [x] Database
* [x] Project runs without errors

---

## Criterion 4

The project has a simple and clean design.

The navigation bar is working.

The code is separated into Models, Views, Controllers, and Data.

The project runs without errors.

The project is also pushed to GitHub.

Screenshots will be included in the final submission.

---

## Screenshots

The screenshots will show the important parts of the project.

Screenshots needed:

1. Product Page
2. Search Product
3. Create Product
4. Product List
5. Edit Product
6. Delete Product
7. Add to Cart
8. Cart Page
9. Update Quantity
10. Remove Item
11. Cart Total
12. GitHub Repository
13. Project Running

---

## My Own Notes

I made this project using ASP.NET Core MVC and SQLite.

I used MVC to separate the code into Models, Views, and Controllers.

I used Entity Framework Core to connect the project to the database.

The Product model is used for the products.

The CartItem model is used for the shopping cart.

The ProductController handles the product functions.

The CartController handles the cart functions.

I also added a search bar so it is easier to find products.

The cart saves the product name, price, and quantity in the database.

---

## Official Microsoft Documentation

I used the official Microsoft documentation to help understand ASP.NET Core MVC and Entity Framework Core.

### ASP.NET Core MVC

https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/

### Adding a Model in ASP.NET Core MVC

https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-10.0

### Entity Framework Core SQLite

https://learn.microsoft.com/en-us/ef/core/providers/sqlite/

### CRUD with Entity Framework Core

https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/crud?view=aspnetcore-10.0

---

## Conclusion

This project is a simple e-commerce website.

It can manage products and a shopping cart.

It has CRUD, search, Add to Cart, quantity update, remove item, and total price.

The project uses ASP.NET Core MVC, C#, Entity Framework Core, and SQLite.

The project is pushed to GitHub and screenshots will be added for the final submission.
