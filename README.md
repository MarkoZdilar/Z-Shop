# Z-shop  - Blazor WebAssembly app #

_Simple web application built with blazor WebAssembly. Entity Framework and code first approach is used here._
<br>
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
                                                          
Here you can find many different games, add them to the cart and place order for your added items. <br> 
Here is how it looks: <br>

<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/130674151-7dfb2ff1-e720-45e9-bcbe-3c9e42c4785f.png" width="90%" >
</p>

You can get a detailed preview for each product by clicking on it:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/130675629-ddd4f71d-22f6-4b15-8aec-e527c1736479.png" width="90%" >
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
  <img src="https://user-images.githubusercontent.com/58775766/130679171-b58a3a47-4441-4ee4-95d6-2211a09ccf1a.png" width="80%" >
</p>

This was done by using already implemented JavaScript free toast implementation for Blazor and Razor Components called ***Blazored Toast***.

More details about it can be found on the link: https://github.com/Blazored/Toast

- - - -
Okay, let's get into our ***Cart*** and see how it looks with some items in it. <br>

Here is the list of all added items. Take a look at the top right corner on the ***Cart*** button - There is a number (🟥) that is showing number of different product variants in our cart, which means that if we have added two same games, but for different platforms, there will be 2 items in your cart. Otherwise there will be only one.
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/130681276-39c22cd0-3ec0-4424-ac12-bf3785f338f8.png" width="90%" >
</p>

Also, each item can be deleted from the cart (🟦) and product quantity can be changed while we are inside of our cart (🟩).<br>
At the bottom right of the page, there is total amount that we need to pay.

By clicking ***"Place Order"*** we'll be redirected to the new page, where all of our items will be shown in the table:
<p align="center">
  <img src="https://user-images.githubusercontent.com/58775766/130683895-468de262-9973-4228-a3a3-3a205dd1dcb3.png" width="60%" >
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
  <img src="https://user-images.githubusercontent.com/58775766/130687406-9affa621-6b0d-4875-9bf4-036d25e3b36d.png" width="90%" >
</p>

***Create*** button appeared, and ***Login*** button has changed to ***Logout*** button.<br>
If real administrator of the page doesn't gave to us Admin role, and we click on ***Create*** button, there will be ***"Not authorized"*** message and we won't be able to create any new product. The same works on for ***Updating*** and ***Deleting*** products on the page.
