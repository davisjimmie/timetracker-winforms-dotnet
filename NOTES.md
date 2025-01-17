*12/29/24 - Start*


# Feature Notes

## Changes

Story (94) Completion coincides with last feautre (93).
No new main codebase updates.

It displays the elapsed time every seconds/milisecond.


*12/29/24 - End*




*12/27/24 - Start*


# Feature Notes

## Changes

**Form1.cs**


- Complete with added methods from TimerService.cs for starting and stiopping time
- Important: Adds DisplayText field from Form1.Designer.cs into constructor allowing TimerService.cs access to update the UI Label.

**Added TimerService.cs**


- Main implementation for the time functionality
- Separate from the Form1 

**Folder Strucure Update**


- Infrastructure > Persistence . for future stories pertaining to adding time to saved work tasks

- Domain > Entities . for creating objects pertaining to timetracker business requirements of storing the allocated time into tasks/projects
	> ex: Entity for a Task with properties: ID, Name, Date, Time: And its associated Behaviors.

- Application > Interfaces, Services, UseCases: 
	> ex: **Interfaces** for the Persistence Repository and Application Level Services, **UseCases** where the Presentation > Forms .  will interact with for
	  opertations pertaining to handling behaviors between assoicating time with the Task entity, and creation of the Task Entity, 			
	  **Services** which orchestrates the Domain Entities, and Repositories for performing an operation such as: *Create New Task* 


Application Layer Structure

1. Interfaces

Purpose:
	Defines contracts for application level services and persistence repositories.

2. UseCases

Purpose: 
	Encapsulates specific business operations or actions that the application needs to perform. 
	Coordinates the necessary steps to fulfill user interactions and business processes such as, creating a new Task/Job for Time Tracker operations.

Interaction: 
	Presentation layer (e.g., Forms) interacts with use cases to handle operations such as adding elapsed time with the Task entity and creating the Task entity.

3. Services

Purpose: 
	Implements business logic and interacts with repositories and other components to perform operations.

Interaction:
	Orchestrates the Domain Entities and Repositories to perform operations such as creating a new task.


## To-Do

- NA


## Other Notes


*12/27/24 - END*





*12.25.24 - START*


# Feature Notes

## Changes

- Added clean architecture folder structure. Not sure if necessary but enjoy the process of learning and implementing it. Seems tricky on Winforms at the moment.
- Implemented Start and Stop button functionality.
- Start begins the time counting in miliseconds. 
- Stop pauses the counting. 
- Start after Stop event resumes counting. 
- Currently no time constraints.


## To-Do

- Refactor Form1.cs. It works but not ready for PR.


## Other Notes
- Keep consistent documentation


*12.25.24 - END*
