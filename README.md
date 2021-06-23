# Services Project: Anime and Manga
By Nsama Chibulu

1. Project Brief.
2. Project Requirements.
3. Project Management.
4. Software Architecture - User Interaction.
5. Software Architecture - Services. 
6. Build. 
7. Testing.
8. Deployment.
9. Issues that occured.
10. Improvements for next time.



# Project Brief 

This project flows nicely from the first project. In the previous application, we were able to create, read, update, and delete anime entries associated with each month. In this project , two services are being created; an Anime service and a Manga’s service. The app will then be able to display, in a frontend, the Anime the user should watch for that month, and also the Manga they should read for that Month. If the user gets one of the big 3 (One Piece, Bleach or Naruto) , the merge service that is responsible for combining te Anime and Managa selections will work to create a message on whether the anime or manga is good ir now.  The output displayed changes every time there is a refresh. 


# Project Requirements 

The project followed the SFIA (Skills Framework for the Information Age) framework and wwas in the form of web-based applications. The requirements were then used to create a MoSCoW table to highlight key features of the minimum viable product. 

![image](https://user-images.githubusercontent.com/82107226/123118401-820cca00-d43a-11eb-8fca-4fa5fca9d002.png)


# Project Management 

For this project, an Agile framework was adopted. This was because a lot of the technologies were familiar, which allowed continuous development and improvement of them.  For my Kanban board , I used Asana, which allowed me to configure timescales to create my own version of mini sprints. 

![image](https://user-images.githubusercontent.com/82107226/123119287-49b9bb80-d43b-11eb-9654-33f8bf097245.png)

![image](https://user-images.githubusercontent.com/82107226/123120028-ea0fe000-d43b-11eb-9a35-7af4e095bdf5.png)

Each sprint is dedicated to a User Story and set of Subtasks to complete within a specified timeframe. With a heavy focus on integration and deployment within this project, the later sprints were longer to allow an adequate amount of time for them. The Build stage also has a longer timeframe to allow for continues improvement and integration of Terraform and Ansible. 
Sprint One: Documentation
Sprint Two: Building of services and overall application
Sprint Three: Testing and Deployment

For this project, a risk assessment was modified and adjusted. Based on prior experience form the Fundamental Project, I decided to have my risk assessment focus heavily on technical disruptions that could have an affect on the project directly.

![image](https://user-images.githubusercontent.com/82107226/123120797-85a15080-d43c-11eb-9933-853c1d65d904.png)


# Software Architecture – User Interaction


The MVP consists of two services that each generate a random output: Anime for Service Two and Manga for Service Three. Service Four will then merge these outputs to provide an output based on the outputs form Service Two and Three, providing a “comment” about the show if it is any of the “Big Three” (Naruto, One Piece, Bleach) and another comment if it is not. The user will then be able to view this in the Frontend, Service One. By refreshing the page, they get a different commbination of anime and manga names. Below shows a flow of how the logic of the services should work to produce the desired output. 

![image](https://user-images.githubusercontent.com/82107226/123149758-85637e00-d459-11eb-8e57-4dafbbc171d5.png)


# Software Architecture - Services  
The project requires the creation of four service. Service Two (Anime) and Service Three (Manga) will generate random entries, which will then be merged into Service Four (Merge). Conditional statements will be used to identify which combination of merged Service Two and Three will generate the comments.
Services Two, Three and Four will be created using webApp APIs in the ASP.NET Core framework. This will allow the generation and combining of the services to take place in an application that will allow them to communicate with each other. The Frontend will be in the form of a MVC web app. Below shows a diagram of how the project is structred to ensure the services do what they are meant to. 

![image](https://user-images.githubusercontent.com/82107226/123149993-c8bdec80-d459-11eb-92ea-09919c857b68.png)


To deploy the services, it was decided to use 4 Azure App Services. This was opposed to the use of Azure Functions as the deployment of App Services was an area of focus for this project, as it wasn’t able to occur in the last project. The Infrastructure of the resources was written in Terraform , where the resources were created , configured , created then deployed via GitHub Actions with pipeplines generated for continuous development.

![image](https://user-images.githubusercontent.com/82107226/123150058-d7a49f00-d459-11eb-90ec-073ea153ec20.png)


# Build 
Backend and Frontend of each application was done in Visual Studio using C# for ASP.NET Core Framework. This included the creation of three Web App API and a MVC Web App, all containing controllers where a most of the codes logic can be found. When opened locally , the apps behave as seen below 

-	Visual Studio set up 

![image](https://user-images.githubusercontent.com/82107226/123122261-c64d9980-d43d-11eb-9fd1-dd461a7267af.png)
  
- Frontend  (Service One)

![image](https://user-images.githubusercontent.com/82107226/123122856-4542d200-d43e-11eb-8d2d-a3f0a879cc37.png)

- Merge API (Service Four)

![image](https://user-images.githubusercontent.com/82107226/123123010-67d4eb00-d43e-11eb-9164-6c468456d7fd.png)
  
 - Anime API (Service Two)
 
![image](https://user-images.githubusercontent.com/82107226/123123287-a10d5b00-d43e-11eb-85e0-1fe2ae8a8354.png)
   
 - Manga API (Service Three)

![image](https://user-images.githubusercontent.com/82107226/123123489-c732fb00-d43e-11eb-8a99-d092831cab73.png)


# Testing 

Unit Testing was carried out on each of the controllers. The following images show the logic being performed and the coverage report generated.

![image](https://user-images.githubusercontent.com/82107226/123123581-d87c0780-d43e-11eb-8ef8-19314a2b908a.png)

![image](https://user-images.githubusercontent.com/82107226/123123625-e2056f80-d43e-11eb-8d4c-37c77ba20e4c.png)


# Deployment 

With the code fully tested (excluding view), it was then time for the deployment stage. Firstly, was to create the resources via Terraform. Terraform was the preferred method as it allowed the application of written Infrastructure as Code to deploy configurable resources into our azure portal. 

![image](https://user-images.githubusercontent.com/82107226/123148598-54cf1480-d458-11eb-8eb8-7aa3a7c9d8e7.png)


With the details specified in our main.tf branch, we then were able to perform the following commands to initiate Terraform, plan Terraform to see if it will create the desired resources with our code, then apply the changes to create the configured resource group and resources in Azure. Image below.

![image](https://user-images.githubusercontent.com/82107226/123149015-ba230580-d458-11eb-9176-cc84c40677f1.png)

After the resources had been created, it was time to deploy our code with CI/CD pipelines. GitHub Actions were used instead of Azure DevOps as it was a new technology that I hadn’t used before and wanted to explore how powerful and convenient actions can be. I published the code via Visual Studio, ensuring that my commits and code in my repo were up to date and that I was working from the correct main branch.

![image](https://user-images.githubusercontent.com/82107226/123123869-1711c200-d43f-11eb-843d-99e40417ccf9.png)

![image](https://user-images.githubusercontent.com/82107226/123123891-1b3ddf80-d43f-11eb-84ae-668fe50ff312.png)

The applications where then successfully deployed to Azure DevOps, with the following pages being displayed.

![image](https://user-images.githubusercontent.com/82107226/123123951-285ace80-d43f-11eb-969e-e88aecf1c6b8.png)

![image](https://user-images.githubusercontent.com/82107226/123123971-2b55bf00-d43f-11eb-8a9e-2a4ceb3addcc.png)

![image](https://user-images.githubusercontent.com/82107226/123123986-2ee94600-d43f-11eb-952d-8600a99293ff.png)

![image](https://user-images.githubusercontent.com/82107226/123124004-33adfa00-d43f-11eb-8814-86c2b72652c4.png)


 The YAML files included in the repository show how each application has its own workflow produced and pipeline. This allowed for automatic changes to code without having to redeploy, as demonstrated in the demo.  Below we have a image of one of the the YAML files (Anime) and its contents, inclduing the build and publish functionalities.
 
 ![image](https://user-images.githubusercontent.com/82107226/123132069-3b24d180-d446-11eb-8269-1b253fca130f.png)



# Issues that Occured

- Testing of Views

After numerous attempts to indepnedtly research way of testing my Views with my Frontend MVC app, I was unable to find a solution which fell into stride with my application and would allow the exclusion of View within the code coverage report. This resulted in having quite a low percentage for branch coverage.

- Terraform

Before creating my resources in Terraform, I did not ignore files within my Gitignore file. This caused problems when coming to commit my code to GitHub as files over the limit of 100MB where present in the commit.

- Ansibel

One of the requirements was to ensure the use of Ansible. I was not abloe to do so as I did not fully understand the use cases, especially with regards to the project. As something that is quite powerful, I hope to be able to utlise to its best in future projects/work. 




# Improvements for Next time

-	Having more advanced features such as button to refresh or schema to interact with. This will allow better experience for the user, something that is highly important when building applications.
-	Incorporation of an SQL database. Due to confidence levels of databases, I was not able to create and use on for my project. This would’ve have been highly useful as it would’ve allowed me to create a greater list of options for my manga and anime selections without disturbing the initial code in VS.
-	One YAML file instead of four would’ve been neater and better, as this is a practise which is used commonly (would help if there are multiple deployments to make). This was not done, again, due to lack of confidence in making the changes and no time to do so. But will be aiming to go forth with this method in the future as the advantages of using it were understood by myself. 







