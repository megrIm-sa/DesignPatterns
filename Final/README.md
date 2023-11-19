
# Name of your final project:
AMD Manufactory

# Group: 
SE-2213

# Team members:
Anton Shvetkoy

# Project Overview:
The project includes the production of computer components and notification of the customer about the completion of the order. The user can select the type of computer components, cost category and type of notification. The program can perform work both for users from the database and for new users entered manually.

# Main body:
The project is conditionally divided into 2 parts: notifying the user and creating computer components.
The project uses Singleton to store a customer database. Provided functionality for adding and removing users.

Part of the notifications contains: an observer for signing and unsubscribing users whose order is being processed. Next is the decorator to choose between notification by mail or via WhatsApp. The following adapter pattern is needed to adapt the interface for sending notifications via mail.

Part of the production contains: the Factor pattern, which allows you to create computer components based on the principle of valuable division. The strategy pattern is used to switch between the production of processors and video cards.

![uml diagram](https://github.com/megrIm-sa/DesignPatterns/blob/main/Final/sdp_final.jpg)

# Conclusion
In my project I used 6 software design patterns: Singleton, Factory, Observer, Decorator, Strategy and Adapter. Working on this project taught me how to combine these patterns together and gave me experience in using design patterns. I managed to implement all the ideas in the project, despite external difficulties, including power and Internet outages, as well as internal ones, such as difficulties with inheritance and keywords when using patterns. In the future, the project can be improved by introducing an external database and expanding the list of products. Also an impressive improvement would be the creation of a GUI.