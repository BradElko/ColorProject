//Global Variables
var Timer;
var seconds;
var accurateclicks;
var inaccurateclicks;
var windowheight = window.innerHeight;
var windowwidth = window.innerWidth;
var colors = ["Red", "Orange", "Yellow", "Green", "Blue", "Purple"];
var randomcolor = colors[Math.floor(Math.random()*colors.length)];
var randomcolor1, randomcolor2;
var selectedcolor1, selectedcolor2;
function BeginGameLoad(){
    //Variables
    var BeginGameContainer = document.getElementById("BGC1");
    var BottomLabel1 = document.getElementById("bl1");
    //Events
    BottomLabel1.addEventListener("mousedown", BL1MD);
    BottomLabel1.addEventListener("mouseup", BL1MU);
    window.addEventListener("contextmenu", BeginGameContextMenu);
    window.addEventListener("resize", BeginGameResize);
    //If Window Height is less then or equal to 600...
    if(windowheight <= 600){
        //Sets the BeginGameContainer Height to 600 pixels.
        BeginGameContainer.style.height = "600px";
    }
    //If Window Width is less then or equal to 800...
    if(windowwidth <= 800){
        //Sets the BeginGameContainer Width to 800 pixels.
        BeginGameContainer.style.width = "800px";
    }
    function BL1MD(e){
        //If you left-click (Mouse Down) the Bottom Label...
        if(e.which == 1 || e.button == 0){
            //Bottom Label Color = Initial Color.
            randomcolor = colors[Math.floor(Math.random()*colors.length)];
            BottomLabel1.style.color = randomcolor;
        }
    }
    function BL1MU(e){
        //If you left-click (Mouse Up) the Bottom Label...
        if(e.which == 1 || e.button == 0){
            /* Goes to the Game Page.
             * Calls the Game Function.
            */
            window.location.href = "Game.html";
            GameLoad();
        }
    }
    function BeginGameContextMenu(e){
        //If you right-click...
        if(e.which == 3 || e.button == 2){
            //Prevent Default.
            e.preventDefault();
        }
    }
    function BeginGameResize(){
        windowheight = window.innerHeight;
        windowwidth = window.innerWidth;
        /* If Window Height is less then or equal to 600...
         * Else If Window Height is greater than 600...
        */
        if(windowheight <= 600){
            //Sets the BeginGameContainer Height to 600 pixels.
            BeginGameContainer.style.height = "600px";
        }else if(windowheight > 600){
            //Sets the BeginGameContainer Height to 100%.
            BeginGameContainer.style.height = "100%";  
        }
        /* If Window Width is less then or equal to 800...
         * Else If Window Width is greater than 800...
        */
        if(windowwidth <= 800){
            //Sets the BeginGameContainer Width to 800 pixels.
            BeginGameContainer.style.width = "800px";
        }else if(windowwidth > 800){
            //Sets the BeginGameContainer Width to 100%.
            BeginGameContainer.style.width = "100%";  
        }
    }
}
function GameLoad(){
    //Variables
    var LeftPanel2 = document.getElementById("lp2");
    var LeftColorPanel2 = document.getElementById("lcp2");
    var TopPanel2 = document.getElementById("tp2");
    var TopLabel2 = document.getElementById("tl2");
    var RightPanel2 = document.getElementById("rp2")
    var RightLabel2 = document.getElementById("rl2");
    var GameContainer = document.getElementById("GC2");
    var MiddleLabelTwo = document.getElementById("mltwo3");
    var MiddleLabelThree = document.getElementById("mlthree3");
    var MiddleLabelFour = document.getElementById("mlfour3");
    var MiddleLabelFive = document.getElementById("mlfive3");
    var clickedRightName = false;
    var clickedRightColor = false;
    var clickedRightNameColor = false;
    var ClickedLeftColorPanel = false;
    var ClickedRightLabel = false;
    var ClickedTopLabel = false;
    //Events
    TopLabel2.addEventListener("mousedown", TL2MD);
    TopLabel2.addEventListener("mouseup", TL2MU);
    TopPanel2.addEventListener("mouseup", TP2MU);
    LeftPanel2.addEventListener("mouseup", LP2MU);
    LeftColorPanel2.addEventListener("mouseup", LCP2MU);
    RightPanel2.addEventListener("mouseup", RP2MU);
    RightLabel2.addEventListener("mouseup", RL2MU);
    window.addEventListener("contextmenu", GameContextMenu);
    window.addEventListener("resize", GameResize);
    //If Window Height is less then or equal to 600...
    if(windowheight <= 600){
        //Sets the GameContainer Height to 600 pixels.
        GameContainer.style.height = "600px";
    }
    //If Window Width is less then or equal to 800...
    if(windowwidth <= 800){
        //Sets the GameContainer Width to 800 pixels.
        GameContainer.style.width = "800px";
    }
    function TL2MD(e){
        /* If clickedRightName == true...
         * If clickedRightColor == true...
         * If clickedRightNameColor == true...
         * If you left-clicked (Mouse Down)...
        */
        if(clickedRightName && clickedRightColor && clickedRightNameColor && (e.which == 1 || e.button == 0)){
            //Top Label Color = Initial Color.
            TopLabel2.style.color = randomcolor;
        }
    }
    function TL2MU(e){
        ClickedTopLabel = true;
        /* If clickedRightName == true...
         * If clickedRightColor == true...
         * If clickedRightNameColor == true...
         * If you left-clicked (Mouse Up)...
        */
        if(clickedRightName && clickedRightColor && clickedRightNameColor && (e.which == 1 || e.button == 0)){
            /* Timer stops.
             * Adds an accurate click.
             * Saves important Variables.
             * Goes to the EndGame Page.
             * Calls the EndGame Function.
            */
            clearInterval(Timer);
            accurateclicks++;
            localStorage.setItem("seconds", seconds);
            localStorage.setItem("accurateclicks", accurateclicks);
            localStorage.setItem("inaccurateclicks", inaccurateclicks);
            window.location.href = "EndGame.html";
            EndGameLoad();
        }
        /* If clickedRightName != true...
         * If clickedRightColor != true...
         * If clickedRightNameColor != true...
         * If Top Label Text == "Click Here To Start"...
         * If you left-clicked (Mouse Up)...
        */
        else if (!clickedRightName 
                 && !clickedRightColor 
                 && !clickedRightNameColor 
                 && TopLabel2.innerHTML == "Click Here To Start"
                 && (e.which == 1 || e.button == 0)){
            /* Timer starts.
             * Variables reset.
             * Top Label Color = Initial Color.
            */
            clearInterval(Timer);
            Timer = setInterval(AddSeconds, 1000);
            seconds = 0;
            accurateclicks = 0;
            inaccurateclicks = 0;
            TopLabel2.innerHTML = randomcolor;
        }
        else{
            //Adds an inaccurate click.
            inaccurateclicks++;
        }
    }
    function TP2MU(e){
        /* If ClickedTopLabel == false...
         * If you left-clicked (Mouse Up)...
         * Else If ClickedTopLabel == true...
        */
        if(!ClickedTopLabel && (e.which == 1 || e.button == 0)){
            //Adds an inaccurate click.
            inaccurateclicks++;
        }else if(ClickedTopLabel){
            //Sets ClickedTopLabel to false.
            ClickedTopLabel = false;
        }
    }
    function LCP2MU(e){
        ClickedLeftColorPanel = true;
        /* If clickerRightColor == false...
         * Top Label Text != "Click Here To Start"...
         * If you left-clicked (Mouse Up)...
        */
        if(!clickedRightColor 
           && TopLabel2.innerHTML != "Click Here To Start" 
           && (e.which == 1 || e.button == 0)){
            while(selectedcolor1 == randomcolor1){
                //Gets random color from list.
                randomcolor1 = colors[Math.floor(Math.random()*colors.length)]; 
            }
            /* If Selected Color != Initial Color.
             * Else If Selected Color == Initial Color.
            */
            if(randomcolor1 != randomcolor){
                /* Left Color Panel Color = Selected Color.
                 * Confirms Selected Color.
                 * Adds an accurate click.
                */
                LeftColorPanel2.style.backgroundColor = randomcolor1;
                selectedcolor1 = randomcolor1;
                accurateclicks++;
            }else if(randomcolor1 == randomcolor){
                /* Left Color Panel Color = Selected Color.
                 * Adds an accurate click.
                 * Sets clickedRightColor to true.
                 * Left Color Panel Cursor = Default.
                */
                LeftColorPanel2.style.backgroundColor = randomcolor1;
                accurateclicks++;
                clickedRightColor = true;
                LeftColorPanel2.style.cursor = "default";
            }
        }
        /* If clickedRightColor == true
         * If you left-clicked (Mouse Up)
        */
        else if(clickedRightColor == true && (e.which == 1 || e.button == 0)){
            //Adds an inaccurate click.
            inaccurateclicks++;
        }
    }
    function LP2MU(e){
        /* If ClickedLeftColorLabel == false...
         * If you left-clicked (Mouse Up)...
         * Else If ClickedLeftColorPanel == true...
        */
        if(!ClickedLeftColorPanel && (e.which == 1 || e.button == 0)){
            //Adds an inaccurate click.
            inaccurateclicks++;   
        }else if(ClickedLeftColorPanel){
            //Sets ClickedLeftColorPanel to false.
            ClickedLeftColorPanel = false;
        }
    }
    function RL2MU(e){
        ClickedRightLabel = true;
        /* If clickerRightName == false...
         * Top Label Text != "Click Here To Start"...
         * If you left-clicked (Mouse Up)...
        */
        if(!clickedRightName 
           && TopLabel2.innerHTML != "Click Here To Start" 
           && (e.which == 1 || e.button == 0)){
            while(selectedcolor2 == randomcolor2){
                //Gets random color from list.
                randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
            }
            /* If Selected Color != Initial Color.
             * Else If Selected Color == Initial Color.
            */
            if(randomcolor2 != randomcolor){
                /* Right Label Text Color = Selected Color.
                 * Confirms Selected Color.
                 * Adds an accurate click.
                */
                RightLabel2.innerHTML = randomcolor2;
                selectedcolor2 = randomcolor2;
                accurateclicks++;
            }else if(randomcolor2 == randomcolor){
                /* Right Label Text Color = Selected Color.
                 * Confirms Selected Color.
                 * Adds an accurate click.
                 * Sets clickedRightName to true.
                */
                RightLabel2.innerHTML = randomcolor2;
                selectedcolor2 = randomcolor2;
                accurateclicks++;
                clickedRightName = true;
            }
        }
        /* If clickerRightName == true...
         * If clickedRightNameColor == false.
         * Top Label Text != "Click Here To Start"...
         * If you left-clicked (Mouse Up)...
        */
        else if(clickedRightName == true && !clickedRightNameColor && (e.which == 1 || e.button == 0)){
            while(selectedcolor2 == randomcolor2){
                //Gets random color from list.
                randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
            }
            /* If Selected Color != Initial Color.
             * Else If Selected Color == Initial Color.
            */
            if(randomcolor2 != randomcolor){
                /* Right Label Color = Selected Color.
                 * Confirms Selected Color.
                 * Adds an accurate click.
                */
                RightLabel2.style.color = randomcolor2;
                selectedcolor2 = randomcolor2;
                accurateclicks++;
            }else if(randomcolor2 == randomcolor){
                /* Right Label Color = Selected Color.
                 * Adds an accurate click.
                 * Sets clickedRightNameColor to true.
                 * Right Label Cursor = Default.
                */
                RightLabel2.style.color = randomcolor2;
                accurateclicks++;
                clickedRightNameColor = true;
                RightLabel2.style.cursor = "default";
            }
        }
        /* If clickedRightName == true...
         * If clickedRightNameColor == true..
         * If you left-clicked (Mouse Up)...
        */
        else if(clickedRightName 
                && clickedRightNameColor 
                && (e.which == 1 || e.button == 0)){
            //Adds an inaccurate click.
            inaccurateclicks++;
        }
    }
    function RP2MU(e){
        /* If ClickedRightLabel == false...
         * If you left-clicked (Mouse Up)...
         * Else If ClickedRightLabel == true...
        */
        if(!ClickedRightLabel && (e.which == 1 || e.button == 0)){
            //Adds an inaccurate click.
            inaccurateclicks++;
        }else if(ClickedRightLabel){
            //Sets ClickedRightLabel to false.
            ClickedRightLabel = false;
        }
    }
    function AddSeconds(){
        //Add 1 Second.
        seconds++;
    }
    function GameContextMenu(e){
        //If you right-click...
        if(e.which == 3 || e.button == 2){
            //Prevent Default.
            e.preventDefault();
        }
    }
    function GameResize(){
        windowheight = window.innerHeight;
        windowwidth = window.innerWidth;
        /* If Window Height is less then or equal to 600...
         * Else If Window Height is greater than 600...
        */
        if(windowheight <= 600){
        //Sets the GameContainer Height to 600 pixels.
            GameContainer.style.height = "600px";
        }else if(windowheight > 600){
        //Sets the GameContainer Height to 100%.
            GameContainer.style.height = "100%";  
        }
        /* If Window Width is less then or equal to 800...
         * Else If Window Width is greater than 800...
        */
        if(windowwidth <= 800){
        //Sets the GameContainer Width to 800 pixels.
            GameContainer.style.width = "800px";
        }else if(windowwidth > 800){
        //Sets the GameContainer Width to 100%.
            GameContainer.style.width = "100%";  
        }
    }
}
function EndGameLoad(){
    //Variables
    var BottomLabel3 = document.getElementById("bl3");
    var EndGameContainer = document.getElementById("EGC3");
    var MiddleLabelTwo = document.getElementById("mltwo3");
    var MiddleLabelThree = document.getElementById("mlthree3");
    var MiddleLabelFour = document.getElementById("mlfour3");
    var MiddleLabelFive = document.getElementById("mlfive3");
    var seconds = localStorage.getItem("seconds");
    var accurateclicks = localStorage.getItem("accurateclicks");
    var inaccurateclicks = localStorage.getItem("inaccurateclicks");
    //Variable Usuage
    MiddleLabelTwo.innerHTML += seconds;
    MiddleLabelThree.innerHTML += accurateclicks;
    MiddleLabelFour.innerHTML += inaccurateclicks;
    MiddleLabelFive.innerHTML += (parseInt(seconds) 
        + parseInt(accurateclicks) 
        + parseInt(inaccurateclicks));
    //Events
    BottomLabel3.addEventListener("mousedown", BL3MD);
    BottomLabel3.addEventListener("mouseup", BL3MU);
    window.addEventListener("contextmenu", EndGameContextMenu);
    window.addEventListener("resize", EndGameResize);
    //If Window Height is less then or equal to 600...
    if(windowheight <= 600){
        //Sets the EndGameContainer Height to 600 pixels.
        EndGameContainer.style.height = "600px";
    }
    //If Window Width is less then or equal to 800...
    if(windowwidth <= 800){
        //Sets the EndGameContainer Width to 800 pixels.
        EndGameContainer.style.width = "800px";
    }
    function BL3MD(e){
        //If you left-click (Mouse Down) the Bottom Label...
        if(e.which == 1 || e.button == 0){
            //Bottom Label Color = Initial Color.
            randomcolor = colors[Math.floor(Math.random()*colors.length)];
            BottomLabel3.style.color = randomcolor;
        }
    }
    function BL3MU(e){
        //If you left-click (Mouse Up) the Bottom Label...
        if(e.which == 1 || e.button == 0){
            /* Resets the Middle Labels.
             * Goes to the Game Page.
             * Calls the Game Function.
            */
            MiddleLabelTwo.innerHTML = "Time (Seconds): "
            MiddleLabelThree.innerHTML = "Accurate Clicks: "
            MiddleLabelFour.innerHTML = "Inaccurate Clicks: "
            MiddleLabelFive.innerHTML = "Score: "
            window.location.href = "Game.html";
            GameLoad();
        }
    }
    function EndGameContextMenu(e){
        //If you right-click...
        if(e.which == 3 || e.button == 2){
            //Prevent Default.
            e.preventDefault();
        }
    }
    function EndGameResize(){
        windowheight = window.innerHeight;
        windowwidth = window.innerWidth;
        /* If Window Height is less then or equal to 600...
         * Else If Window Height is greater than 600...
        */
        if(windowheight <= 600){
            //Sets the EndGameContainer Height to 600 pixels.
            EndGameContainer.style.height = "600px";
        } else if(windowheight > 600){
            //Sets the EndGameContainer Height to 100%.
            EndGameContainer.style.height = "100%";  
        }
        /* If Window Width is less then or equal to 800...
         * Else If Window Width is greater than 800...
        */
        if(windowwidth <= 800){
            //Sets the EndGameContainer Width to 800 pixels.
            EndGameContainer.style.width = "800px";
        }else if(windowwidth > 800){
            //Sets the EndGameContainer Width to 100%.
            EndGameContainer.style.width = "100%";  
        }
    }
}