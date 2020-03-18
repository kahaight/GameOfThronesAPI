# GameOfThronesAPI
<!-- PROJECT LOGO -->
<br />
<p align="center">


  <a href="https://github.com/jackmccoy34/GameOfThronesAPI">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">GameOfThronesAPI</h3>

  <p align="center">
    A complete guide to HBO's Game of Thrones
    <br />

    <a href="https://github.com/jackmccoy34/GameOfThronesAPI"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/jackmccoy34/GameOfThronesAPI">View Demo</a>
    ·
    <a href="https://github.com/jackmccoy34/GameOfThronesAPI/issues">GameOfThronesAPIrt Bug</a>
    ·
    <a href="https://github.com/jackmccoy34/GameOfThronesAPI/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
  * [Built With](#built-with)
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [Installation](#installation)
* [Usage](#usage)
* [Contributing](#contributing)
* [Contact](#contact)
* [Acknowledgements](#acknowledgements)



<!-- ABOUT THE PROJECT -->
## About The Project

[![Game of Thrones API][C:\Users\jack\OneDrive\Pictures]](https://github.com/kahaight/GameOfThronesAPI)

Here's a blank template to get started:
**To avoid retyping too much info. Do a search and replace with your text editor for the following:**
`jackmccoy34`, `GameOfThronesAPI`, `twitter_handle`, `jackmccoy34@gmail.com`

We've created an API Web Application related to the fantasy world portrayed in the "Game of Thrones" telivision series.
The intended use for our project is to have the ability to retreive specific Game of Thrones information from a user's request. 
The client will send a request specifying which endpoint to be used. The API then takes this request to the server. 
From the server, a response containing the desired data is returned. The data is then converted into a readable response and 
will be displayed on the user's interface. This API can be used by anyone with a need for specified Game of Thrones
information, who would like to shorten their research time.  

### Built With

* [Visual Studio Code](https://visualstudio.microsoft.com/downloads/) - Development Environment
* [Postman](https://www.postman.com/) - API Client
* [Github](https://github.com/kahaight/GameOfThronesAPI) - Host/Collaboration Service
* Entity Framework
* Owin


<!-- GETTING STARTED -->
## Getting Started

To get a local copy of the Game of Thrones database up and running follow these simple steps.

### Prerequisites

You will need a copy of Visual Studio 2019 as well as Postman to utilize the API's endpoints easily. Follow the links below should you do not have the free software installed already.
* [Visual Studio Code](https://visualstudio.microsoft.com/downloads/)

* [Postman](https://www.postman.com/)


### Game of Thrones API
```sh 
1. Clone the Solution from GitHub using the link the solution below. After navigating there and cloning open using Visual Studio.
```
[Clone the API for Visual Studios Here](https://github.com/kahaight/GameOfThronesAPI)


```sh
2. Be sure to restore the NuGet Packages for the GoTAPI solution
```
Right click on your opened Solution 'GoTAPI' and select "restore NuGet Packages" (and then bring in using statements if needed).


```sh
3.Run the Solution and open Postman to utilize the database
```
With a running solution and Postman get features ready to be utilized there are a myriad of different endpoints, most importantly 9 GET endpoints for reference in any Game of Thrones lookup.


<!-- USAGE EXAMPLES -->
## Usage
This API is meant to be used as a resource that cross-cordinates Houses, Characters, Affilitions, and Episodes in various ways to help broaden an understanding of HBO's hit series Game of Thrones.


When researching we can get a list, in this case of characters, with Id numbers as seen below. Let's note Tyrion's Id.

[![Character List Screen Shot][screenshot-1]]


Then by adding a forward slash and the Id number of Tyrion we can bring up Tyrion's corresponding detail page.

[![Tyrion detail Page 1][screenshot-2]]


These details pages are fairly extensive as we combine 4 independent classes using 3 joining tables to present a character's; Id, Name, wheter they are alive, their episode of death, House, Gender, Actor, Cause of Death, Episodes, and Affiliations.

[!Tyrion detail Page 2][screenshot-3]] 


<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<!-- CONTACT -->
## Contact

* Konrad Haight - konradhaight@gmail.com
* Marshall Davis - marmadav@gmail.com
* Jack McCoy - jackmccoy34@gmail.com

Project Link: [https://github.com/kahaight/GameOfThronesAPI](https://github.com/kahaight/GameOfThronesAPI)

<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [Game of Thrones Wiki](https://gameofthrones.fandom.com/wiki/Game_of_Thrones_Wiki)
* [A Wiki of Ice and Fire](https://awoiaf.westeros.org/index.php/Main_Page)
* [IMDB](https://www.imdb.com/)
* [Game of Thrones Death Timeline](http://deathtimeline.com/)
* [Wikipedia Episode List](https://en.wikipedia.org/wiki/List_of_Game_of_Thrones_episodes)


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=flat-square
[contributors-url]: https://github.com/othneildrew/Best-README-Template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=flat-square
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=flat-square
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=flat-square
[issues-url]: https://github.com/othneildrew/Best-README-Template/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=flat-square
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[screenshot-2]: Images/InkedTyrion first detail shot.jpg
[screenshot-1]: Images/Tyrion character list shot with pen highlight.png
[screenshot-3]: Images/InkedTyrion second detail shot.jpg
