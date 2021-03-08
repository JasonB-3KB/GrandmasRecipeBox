# Grandma's Recipe Box
> Converting all those pages and recipe cards into an easy to use digital application!

## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Features](#features)
* [Status](#status)
* [Inspiration](#inspiration)
* [Contact](#contact)

## General info
As a Blue Badge final project, our team WYSIWYG decided upon creating a Recipe application that would essentially
replace all your recipes around your house, whether they were on papers or 3x5 cards, and make a one stop shop for 
all your favorite recipes in one easy to find location.


## Technologies
* Visual Studio Community 2019 - version 16.9.0 


## Code Examples
public bool CreateRecipe(RecipeCreate model)
        {
            var entity =
                new Recipe()
                {
                    OwnerId = _userId,
                    RecipeName = model.RecipeName,
                    Ingredients = model.Ingredients,
                    Instructions = model.Instructions,
                    SourceId = model.SourceId,
                    TypeOfCuisine = model.TypeOfCuisine,
                    TypeOfDish = model.TypeOfDish
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Recipes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

## Features
* Add a brand new recipe in just a few steps!
* Need to change the recipe a little? No problem, quickly and easily make changes to your recipe.
* Did the recipe not feed enough? Or did it seem too tomato-ey? Add a comment to your recipe for future reference!

To-do list:
* Add external source recipes
* Search by type of food

## Status
Project is: _in progress_, there is still a lot of room for growth within this application.

## Inspiration
This project was inspired by the desire to cook a variety of foods, but with the simplicity of using a one stop solution in the form of an app.

## Instructions
* Using Postman- register for your token
* Start running the app- copy and paste your link for Posting a source from your localhost API page
* Once you have posted a source with a 200 status, then you are ready to add a recipe using that source ID
* After the recipe is posted, you can now use the Recipe Id to post a comment on your recipe.
* If you now choose the Get recipe endpoint, you will see all of your information for that recipe, including a comment!

## Contact
Created by @Team_wysiwyg - Jeannette Schriner, Emilie Rains, Bobby Hammer, and Jason Bagwill

## References
References used to help create Grandma’s Recipe Box project.

[Creating a readme](http://www.makeareadme.com)

[Creating a readme](http://bulldog.com/news/449-how-to-write-a-good-readme-for-your-github-project)

[API help](https://docs.microsoft.com/en-us/aspnet/web-api/overview/getting-started-with-aspnet-web-api/creating-api-help-pages) 

[Disable XML warnings](https://stackoverflow.com/questions/7982525/visual-studio-disabling-missing-xml-comment-warning) 

[Intro to bootstrap](https://www.youtube.com/watch?v=vRqz_zUiJTw&feature=youtu.be) 

[Foreign Keys Part A](https://www.youtube.com/watch?v=tvq9U4K2p-s&feature=youtu.be)

[Foreign Keys Part B](https://www.youtube.com/watch?v=XMvF_KUxKRA&feature=youtu.be) 

[XML missing](https://www.compilemode.com/2021/01/cs1591-missing-xml-comment-for-publicly-type-or-member.html) 

[Eleven-Note reference](https://elevenfifty.instructure.com/courses/550/pages/eleven-note)

[24hr assignment reference](https://elevenfifty.instructure.com/courses/550/assignments/9416) 

[Linq quearys](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/basic-linq-query-operations) 

[WYSIWYG planning doc](https://docs.google.com/document/d/19UD_SP4vk9PIlEWFYpyy_UXuN3V4oWbJAKHnf4kF3kc/edit?ts=6035aae6#heading=h.apyy2fblhnhk) 

[Stack Overflow identityuser help](https://stackoverflow.com/questions/40532987/how-to-extend-identityuser-with-custom-property/)

[Relationship in Entity Framework](https://www.c-sharpcorner.com/UploadFile/3d39b4/relationship-in-entity-framework-using-code-first-approach-w/)

[Database designing](https://docs.oracle.com/cd/E57185_01/EDBAG/dindesin.html) 

[More Entity relationship information](http://mirror.informatimago.com/next/developer.apple.com/documentation/LegacyTechnologies/WebObjects/WebObjects_4.5/System/Documentation/Developer/EnterpriseObjects/DevGuide/ApA_ERMd.html)

[Recipe references](https://cooking.nytimes.com/) 

[Designing a relational database](https://dev.to/amckean12/designing-a-relational-database-for-a-cookbook-4nj6)

