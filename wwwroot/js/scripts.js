$(document).ready(function(){
  var boo = new Audio('/audio/train.mp3')
  $("body").click(function(){
    boo.play();
  });
});
