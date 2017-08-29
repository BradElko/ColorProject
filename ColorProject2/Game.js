//Global Variables
var Timer;
var seconds;
var accurateclicks;
var inaccurateclicks;
var windowheight = window.innerHeight;
var windowwidth = window.innerWidth;
var colors = ["Red", "Orange", "Yellow", "Green", "Blue", "Purple"];
var randomcolor = colors[Math.floor(Math.random()*colors.length)];
//BeginGameLoad Function
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
        BeginGameContainer.style.height = "600px";
    }
    //If Window Width is less then or equal to 800...
    if(windowwidth <= 800){
        BeginGameContainer.style.width = "800px";
    }
    //BL1MD Function
    function BL1MD(e){
        if(e.which == 1 || e.button == 0){
            var randomcolor = colors[Math.floor(Math.random()*colors.length)];
            BottomLabel1.style.color = randomcolor;
        }
    }
    //BL1MU Function
    function BL1MU(e){
        if(e.which == 1 || e.button == 0){
            window.location.href = "Game.html";
            GameLoad();
        }
    }
    //BeginGameContextMenu Function
    function BeginGameContextMenu(e){
        if(e.which == 3 || e.button == 2){
            e.preventDefault();
        }
    }
    //BeginGameResize Function
    function BeginGameResize(){
        windowheight = window.innerHeight;
        windowwidth = window.innerWidth;
        if(windowheight <= 600){
            BeginGameContainer.style.height = "600px";
        }else if(windowheight > 600){
            BeginGameContainer.style.height = "100%";  
        }
        if(windowwidth <= 800){
            BeginGameContainer.style.width = "800px";
        }else if(windowwidth > 800){
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
    TopPanel2.addEventListener("mouseup", TP2MU);
    TopLabel2.addEventListener("mousedown", TL2MD);
    TopLabel2.addEventListener("mouseup", TL2MU);
    LeftPanel2.addEventListener("mouseup", LP2MU);
    LeftColorPanel2.addEventListener("mouseup", LCP2MU);
    LeftColorPanel2.addEventListener("mousedown", LCP2MD);
    RightPanel2.addEventListener("mouseup", RP2MU);
    RightLabel2.addEventListener("mouseup", RL2MU);
    RightLabel2.addEventListener("mousedown", RL2MD);
    window.addEventListener("resize", GameResize);
    window.addEventListener("contextmenu", GameContextMenu);
    //If Window Height is less then or equal to 600...
    if(windowheight <= 600){
        GameContainer.style.height = "600px";
    }
    //If Window Width is less then or equal to 800...
    if(windowwidth <= 800){
        GameContainer.style.width = "800px";
    }
    function AddSeconds(){
        seconds++;
    }
    function GameContextMenu(e){
        if(e.which == 3 || e.button == 2){
            e.preventDefault();
        }
    }
    function TL2MD(e){
        if(e.which == 3 || e.button == 2){
            e.preventDefault();
            RightClick = true;
        }
        else if(clickedRightName == true && clickedRightColor == true && clickedRightNameColor == true){
            TopLabel2.style.color = randomcolor;
            RightClick = false;
        }
    }
    function TP2MU(){
        if(ClickedTopLabel == false){
            inaccurateclicks++;
        }
        else{
            ClickedTopLabel = false;
        }
    }
    function TL2MU(){
        ClickedTopLabel = true;
        if(clickedRightName == true && clickedRightColor == true && clickedRightNameColor == true && RightClick == false){
            clearInterval(Timer);
            accurateclicks++;
            window.location.href = "EndGame.html";
            localStorage.setItem("seconds", seconds);
            localStorage.setItem("accurateclicks", accurateclicks);
            localStorage.setItem("inaccurateclicks", inaccurateclicks);
            EndGameLoad();
        }
        else if (!clickedRightName == true && !clickedRightColor == true && !clickedRightNameColor == true && TopLabel2.innerHTML != randomcolor && RightClick == false){
            clearInterval(Timer);
            Timer = setInterval(AddSeconds, 1000);
            seconds = 0;
            accurateclicks = 0;
            inaccurateclicks = 0;
            TopLabel2.innerHTML = randomcolor;
            RightClick = false;
        }
        else{
            inaccurateclicks++;
        }
        RightClick == false
    }
    function LCP2MD(e){
        if(e.which == 3 || e.button == 2){
            e.preventDefault();
            RightClick = true;
        }
        else{
            RightClick = false;
        }
    }
    function LCP2MU(){
        ClickedLeftColorPanel = true;
        if(clickedRightColor == false && TopLabel2.innerHTML != "Click Here To Start" && RightClick == false){
            var randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
            while (randomcolor2.toLowerCase() == LeftColorPanel2.style.backgroundColor){
                randomcolor2 = null;
                randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
                if(randomcolor2.toLowerCase() != LeftColorPanel2.style.color){
                    LeftColorPanel2.style.backgroundColorr = randomcolor2;
                    accurateclicks++;
                    break;
                }
            }
            if(randomcolor2.toLowerCase() != LeftColorPanel2.style.backgroundColor){
                LeftColorPanel2.style.backgroundColor = randomcolor2;
                accurateclicks++;
            }
            if (LeftColorPanel2.style.backgroundColor == randomcolor.toLowerCase()){
                clickedRightColor = true;
                LeftColorPanel2.style.cursor = "auto";
            } 
            randomcolor2 = null;
            RightClick = false;
        }
        else if(clickedRightColor == true && RightClick == false){
            inaccurateclicks++;
        }
    }
    function LP2MU(){
        if(ClickedLeftColorPanel == false){
            inaccurateclicks++;   
        }
        else{
            ClickedLeftColorPanel = false;
        }
    }
    function RL2MD(e){
        if(e.which == 3 || e.button == 2){
            e.preventDefault();
            RightClick = true;
        }
        else{
            RightClick = false;
        }
    }
    function RL2MU(){
        ClickedRightLabel = true;
        if(clickedRightName == false && TopLabel2.innerHTML != "Click Here To Start" && RightClick == false){
            var randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
            while (randomcolor2 == RightLabel2.innerHTML){
                randomcolor2 = null;
                randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
                if(randomcolor2 != RightLabel2.innerHTML){
                    RightLabel2.innerHTML = randomcolor2;
                    accurateclicks++;
                    break;
                }
            }
            if(randomcolor2 != RightLabel2.color){
                RightLabel2.innerHTML = randomcolor2;
                accurateclicks++;
            }
            if (RightLabel2.innerHTML == randomcolor){
                clickedRightName = true;
            }
            randomcolor2 = null;
        }
        else if(clickedRightName == true && clickedRightNameColor == false && RightClick == false){
            var randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
            while (randomcolor2.toLowerCase() == RightLabel2.style.color){
                randomcolor2 = null;
                randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
                if(randomcolor2.toLowerCase() != RightLabel2.style.color){
                    RightLabel2.style.color = randomcolor2;
                    accurateclicks++;
                    break;
                }
            }
            if(randomcolor2.toLowerCase() != RightLabel2.style.color){
                RightLabel2.style.color = randomcolor2;
                accurateclicks++;
            }
            if (RightLabel2.style.color == randomcolor.toLowerCase()){
                clickedRightNameColor = true;
                RightLabel2.style.cursor = "auto";
            }
            randomcolor2 = null;
        }
        else if(clickedRightName == true && clickedRightNameColor == true && RightClick == false){
            inaccurateclicks++;
        }
    }
    function RP2MU(){
        if(ClickedRightLabel == false){
            inaccurateclicks++;
        }
        else{
            ClickedLeftColorPanel = false;
        }
    }
    function GameResize(){
        windowheight = window.innerHeight;
        windowwidth = window.innerWidth;
        if(windowheight <= 600)
        {
            GameContainer.style.height = "600px";
        }
        if(windowheight > 600)
        {
            GameContainer.style.height = "100%";  
        }
        if(windowwidth <= 800)
        {
            GameContainer.style.width = "800px";
        }
        if(windowwidth > 800)
        {
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
    BottomLabel3.style.cursor = "pointer";
    window.addEventListener("resize", EndGameResize);
    window.addEventListener("contextmenu", EndGameContextMenu);
    if(windowheight <= 600){
        EndGameContainer.style.height = "600px";
    }
    if(windowwidth <= 800){
        EndGameContainer.style.width = "800px";
    }
    function EndGameContextMenu(e){
        if(e.which == 3 || e.button == 2){
            e.preventDefault();
        }
    }
    function BL3MD(e){
        if(e.which == 1 || e.button == 0){
            randomcolor = colors[Math.floor(Math.random()*colors.length)];
            BottomLabel3.style.color = randomcolor;
            RightClick = false;
        }
    }
    function BL3MU(e){
        if(e.which == 1 || e.button == 0){
            MiddleLabelTwo.innerHTML = "Time (Seconds): "
            MiddleLabelThree.innerHTML = "Accurate Clicks: "
            MiddleLabelFour.innerHTML = "Inaccurate Clicks: "
            MiddleLabelFive.innerHTML = "Score: "
            window.location.href = "Game.html";
            GameLoad();
        }
    }
    function EndGameResize(){
        windowheight = window.innerHeight;
        windowwidth = window.innerWidth;
        if(windowheight <= 600){
            EndGameContainer.style.height = "600px";
        } else if(windowheight > 600){
            EndGameContainer.style.height = "100%";  
        }
        if(windowwidth <= 800){
            EndGameContainer.style.width = "800px";
        }else if(windowwidth > 800){
            EndGameContainer.style.width = "100%";  
        }
    }
}