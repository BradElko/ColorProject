function BeginGameLoad(){
    var windowheight = window.innerHeight;
    var windowwidth = window.innerWidth;
    var colors = ["Red", "Orange", "Yellow", "Green", "Blue", "Purple"];
    var BottomLabel1 = document.getElementById("bl1");
    var BeginGameContainer = document.getElementById("BGC1");
    var RightClick = false;
    BottomLabel1.addEventListener("mousedown", BL1MD);
    BottomLabel1.addEventListener("mouseup", BL1MU);
    window.addEventListener("resize", BeginGameResize);
    window.addEventListener("contextmenu", BeginGameContextMenu);
    function BeginGameContextMenu(e){
        if(e.which == 3 || e.button == 2){
            e.preventDefault();
        }
    }
    function BL1MD(e){
        if(e.which == 3 || e.button == 2){
            e.preventDefault();
            RightClick = true;
        }
        else{
            var randomcolor = colors[Math.floor(Math.random()*colors.length)];
            BottomLabel1.style.color = randomcolor;
            RightClick = false;
        }
    }
    function BL1MU(){
        if(RightClick == false){
            window.location.href = "Game.html";
        }
        else{
            RightClick = false;
        }
    }
    if(windowheight < 600)
    {
        BeginGameContainer.style.height = "600px";
    }
    if(windowwidth < 800)
    {
        BeginGameContainer.style.width = "800px";
    }
    function BeginGameResize(){
        windowheight = window.innerHeight;
        windowwidth = window.innerWidth;
        if(windowheight <= 600)
        {
            BeginGameContainer.style.height = "600px";
        }
        if(windowheight > 600)
        {
            BeginGameContainer.style.height = "100%";  
        }
        if(windowwidth <= 800)
        {
            BeginGameContainer.style.width = "800px";
        }
        if(windowwidth > 800)
        {
            BeginGameContainer.style.width = "100%";  
        }
    }
}
function GameLoad(){
    var windowheight = window.innerHeight;
    var windowwidth = window.innerWidth;
    var colors = ["Red", "Orange", "Yellow", "Green", "Blue", "Purple"];
    var randomcolor = colors[Math.floor(Math.random()*colors.length)];
    var LeftColorPanel2 = document.getElementById("lcp2");
    var TopLabel2 = document.getElementById("tl2");
    var RightLabel2 = document.getElementById("rl2");
    var GameContainer = document.getElementById("GC2");
    var clickedRightName = false;
    var clickedRightColor = false;
    var clickedRightNameColor = false;
    var clicks = 0;
    var RightClick = false;
    TopLabel2.addEventListener("mousedown", TL2MD);
    TopLabel2.addEventListener("mouseup", TL2MU);
    LeftColorPanel2.addEventListener("mouseup", LCP2MU);
    LeftColorPanel2.addEventListener("mousedown", LCP2MD);
    RightLabel2.addEventListener("mouseup", RL2MU);
    RightLabel2.addEventListener("mousedown", RL2MD);
    window.addEventListener("resize", GameResize);
    window.addEventListener("contextmenu", GameContextMenu);
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
        else{
            TopLabel2.innerHTML = randomcolor;
            RightClick = false;
        }
    }
    function TL2MU(){
        if(clickedRightName == true && clickedRightColor == true && clickedRightNameColor == true && RightClick == false){
            clicks++;
            window.location.href = "EndGame.html";
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
        if(clickedRightColor == false && TopLabel2.innerHTML != "Click Here To Start" && RightClick == false){
            var randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
            while (randomcolor2.toLowerCase() == LeftColorPanel2.style.backgroundColor){
                randomcolor2 = null;
                randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
                if(randomcolor2.toLowerCase() != LeftColorPanel2.style.color){
                    LeftColorPanel2.style.backgroundColorr = randomcolor2;
                    clicks++;
                    break;
                }
            }
            if(randomcolor2.toLowerCase() != LeftColorPanel2.style.backgroundColor){
                LeftColorPanel2.style.backgroundColor = randomcolor2;
                clicks++;
            }
            if (LeftColorPanel2.style.backgroundColor == randomcolor.toLowerCase()){
                clickedRightColor = true;
            } 
            randomcolor2 = null;
            RightClick = false;
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
        if(clickedRightName == false && TopLabel2.innerHTML != "Click Here To Start" && RightClick == false){
            var randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
            while (randomcolor2 == RightLabel2.innerHTML){
                randomcolor2 = null;
                randomcolor2 = colors[Math.floor(Math.random()*colors.length)];
                if(randomcolor2 != RightLabel2.innerHTML){
                    RightLabel2.innerHTML = randomcolor2;
                    clicks++;
                    break;
                }
            }
            if(randomcolor2 != RightLabel2.color){
                RightLabel2.innerHTML = randomcolor2;
                clicks++;
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
                    clicks++;
                    break;
                }
            }
            if(randomcolor2.toLowerCase() != RightLabel2.style.color){
                RightLabel2.style.color = randomcolor2;
                clicks++;
            }
            if (RightLabel2.style.color == randomcolor.toLowerCase()){
                clickedRightNameColor = true;
            }
            randomcolor2 = null;
        }
    }
    if(windowheight < 600)
    {
        GameContainer.style.height = "600px";
    }
    if(windowwidth < 800)
    {
        GameContainer.style.width = "800px";
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
    var windowheight = window.innerHeight;
    var windowwidth = window.innerWidth;
    var colors = ["Red", "Orange", "Yellow", "Green", "Blue", "Purple"];
    var BottomLabel3 = document.getElementById("bl3");
    var EndGameContainer = document.getElementById("EGC3");
    var RightClick = false;
    BottomLabel3.addEventListener("mousedown", BL3MD);
    BottomLabel3.addEventListener("mouseup", BL3MU);
    window.addEventListener("resize", EndGameResize);
    window.addEventListener("contextmenu", EndGameContextMenu);
    function EndGameContextMenu(e){
        if(e.which == 3 || e.button == 2){
            e.preventDefault();
        }
    }
    function BL3MD(e){
        if(e.which == 3 || e.button == 2){
            e.preventDefault();
            RightClick = true
        }
        else{
            var randomcolor = colors[Math.floor(Math.random()*colors.length)];
            BottomLabel3.style.color = randomcolor;
            RightClick = false;
        }
    }
    function BL3MU(){
        if(RightClick == false){
            window.location.href = "Game.html";
        }
    }
    if(windowheight < 600)
    {
        EndGameContainer.style.height = "600px";
    }
    if(windowwidth < 800)
    {
        EndGameContainer.style.width = "800px";
    }
    function EndGameResize(){
        windowheight = window.innerHeight;
        windowwidth = window.innerWidth;
        if(windowheight <= 600)
        {
            EndGameContainer.style.height = "600px";
        }
        if(windowheight > 600)
        {
            EndGameContainer.style.height = "100%";  
        }
        if(windowwidth <= 800)
        {
            EndGameContainer.style.width = "800px";
        }
        if(windowwidth > 800)
        {
            EndGameContainer.style.width = "100%";  
        }
    }
}