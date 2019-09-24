Identify one point that illustrated something not to do that you do or tend to do.

        I tend to have a bunch of if/else statements in a row in one method

Identify one point that surprised you and explain why
    
        I was surprised by the explicit instructions to use getters and setters. They are super helpful and 
        arguably the correct way to code almost always but sometimes using a getter/setter makes it harder
        to acomplish your task at hand/goal. 
        

Identify one point that you disagree with, if any, and why

        Accorrding to the documentation it is bad to do negative conditionals but I disagree. 
        It is possible to have: 
        
            if (IsDOMNodePresent(node))
            {
                // ...
            }

        But that is only possible if something happens when the bool is true. 
        
        Sometimes something only happens if a bool is false and so it would be necessary, and not bad to do: 
        
            if (!IsDOMNodeNotPresent(node))
            {
                // ...
            }
        
        
        
