#pragma strict

var canvas : Canvas;

var time = 0;


function Start () {
    canvas.enabled = false;
	
}

function OnTriggerEnter (info : Collider) {

      if(info.tag == "BubbleStart"){
          canvas.enabled = true;
      }
}

      function OnTriggerEnd (info : Collider) {
         if(info.tag == "BubbleStart"){
          canvas.enabled = false;
      }

	
}
//function OnTriggerExit (info : Collider) {
//
//      if(info.tag == "BubbleStart"){
//          canvas.enabled = false;
//
//      }
//	
//}