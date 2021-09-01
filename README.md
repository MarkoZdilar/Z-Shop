# Z-shop  - Blazor WebAssembly app #

_Simple web application built with blazor WebAssembly. Entity Framework and code first approach is used here._
<br>
- - - -
This application was created with the help of ***Patrick God*** and his great course known as ***_Blazor E-Commerce Series_***, which can be found on the link -> [Blazor E-Commerce Series](https://www.youtube.com/watch?v=ITk2MTFpiA4&list=PLF1jhYUTnHo6oK14WD3D_abbluAj0aiRb). <br>
Also, here is the link to his github repo where many great projects can be found -> [Patrick's GitHub repo](https://github.com/patrickgod).

Of course, the development of this application continued after the end of the mentioned course.
- - - -
### About the app ###
Z-Shop is web shop application where you can find video games for different platforms such as:
* PC
* PlayStation 3,
* PlayStation 4,
* PlayStation 5,
* Xbox 360,
* Xbox One,
* Xbox Series X,
* Nintendo Wii.
                                                          
This is the place with many different games, where you can add them to the cart and place the order for your items. <br> 
Here is how it looks: <br>

<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/131745964-1019d67e-14da-4132-9f3f-b11f73fa8c33.png" width="90%" >
</p>

If we just want to show games for the specific category, it can be done via dropdown:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/131750338-c6d08dd8-09a8-49c8-a350-44d0db1738d6.png" width="90%" >
</p>

You can get a detailed preview for each product by clicking on it:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/131746037-48c76092-a956-4414-b360-b2d53cbf0f8a.png" width="90%" >
</p>

So, there is implementation of different product variants on this page, which means that for each game there is different platforms available, and each game can have different prices for the selected platform. Platform can be selected from the dropdown:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/130677989-7f0c175a-0c17-4fa6-bd46-c5145598def5.png" width="80%" >
</p>

You can select quantity for each item by entering wanted number inside ***InputNumber*** field:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/130677221-b0ed6507-9fd9-403c-8100-c8e9ebdcc28d.png" width="60%" >
</p>

Also, there is view counter at the bottom right corner of the selected product:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/130677628-054f198c-ec45-4e93-b91c-b55f32c4d02b.png" width="60%" >
</p>

By clicking on ***"Add to cart"*** specified quantity of the selected item will be added to your cart. Also, popup message will be shown when item is added:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/131746163-d9dba0d1-4f1c-4f10-8320-5bd9cae36952.png" width="80%" >
</p>

This was done by using already implemented JavaScript free toast implementation for Blazor and Razor Components called ***Blazored Toast***.

More details about it can be found on the link: https://github.com/Blazored/Toast

- - - -
Okay, let's get into our ***Cart*** and see how it looks with some items in it. <br>

Here is the list of all added items. Take a look at the top right corner on the ***Cart*** button - There is indicator (🟥) that is showing a number of different product variants in our cart, which means that if we have added two same games, but for different platforms, there will be 2 items in your cart. Otherwise there will be only one.
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/131746717-36ed9a53-f7b7-43f3-95d8-97fb07db32ad.png" width="90%" >
</p>

Also, each item can be deleted from the cart (🟦) and product quantity can be changed while we are inside of our cart (🟩).<br>
At the bottom right of the page, there is total amount that we need to pay.

Deleting product from the cart will result with new popup:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/131746894-272f06ca-fd37-4990-8218-4be94e91b10e.png" width="60%" >
</p>

By clicking ***"Place Order"*** we'll be redirected to the new page, where all of our items will be shown in the table:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/131747113-d7458163-9534-4b18-a98e-3a8cfb3b3414.png" width="60%" >
</p>

- - - -

Now, let's get into ***Login*** and ***Register*** forms. <br>
We can get to our login page by clicking ***"Login"*** button at the top right corner of the page:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/130684783-085e779e-2e5b-46ea-9c7f-c44ee5f8534d.png" width="80%" >
</p>

If we haven't registered yet, there is a link to the registration page:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/130685790-f4069366-1a6f-4c38-ad78-586af078b165.png" width="60%" >
</p>

Registration form:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/130686001-dd03c2ba-145b-44c5-b332-fc50dd181c70.png" width="60%" >
</p>

Here we are registering our new user.<br>
In order to get Admin role, real administrator of the page needs to manually insert Admin role to your account in the database. This approach can be avoided by adding ***SuperAdmin*** role, which will also be manually added to the database, but later we will be able to give ***Administrator roles*** to newly registered users without entering it manually into the database.

By logging in as an Admin, we will get access to ***Create***, ***Update*** and ***Delete*** products on the page.

After logging in, we can see that there is a few changes on the site:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/131747270-73086cb8-ef8d-4b82-9433-c5fcea30bdce.png" width="90%" >
</p>

***Create*** button appeared, and ***Login*** button has changed to ***Logout*** button. Also, welcome message has changed from _Welcome to Z-Shop_ to _Welcome back, ***user***_!<br>

If real administrator of the page doesn't gave to us Admin role, and we click on ***Create*** button, there will be ***"Not authorized"*** message and we won't be able to create any new product. The same works on for ***Updating*** and ***Deleting*** products on the page.

Going to the ***Product Details***, we will see that two new buttons has appeared -> ***Delete*** and ***Edit***: 
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/131747685-0dbe1034-8dcf-4245-bbb0-f48ea92ef95d.png" width="80%" >
</p>

Clicking on ***Delete***, our product will be deleted from the database with all of it's variants, page will refresh and product will disappear from the page.

Going to ***Edit*** button, form will appear and we'll be able to update each property of the selected product:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/131748039-69935cb5-0806-4d6a-9f82-cbef640096e5.png" width="90%" >
  <img src="https://user-images.githubusercontent.com/58775766/131748123-b92588c9-f55f-4026-8114-df54435311f1.png" width="90%" >
</p>

The same form will appear with clicking on ***Create***, but it'll be the empty one.
