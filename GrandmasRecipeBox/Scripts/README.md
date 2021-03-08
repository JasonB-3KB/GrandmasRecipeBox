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
* Wow improvement to be done 1
* Wow improvement to be done 2

## Status
Project is: _in progress_, there is still a lot of room for growth within this application.

## Inspiration
This project was inspired by the desire to cook a variety of foods, but with the simplicity of using a one stop solution in the form of an app.

## Contact
Created by @Team_wysiwyg - Jeannette Schriner, Emilie Rains, Bobby Hammer, and Jason Bagwill
