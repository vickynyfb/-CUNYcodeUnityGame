var end : Fade_Scene;
end = GameObject.Find("End").GetComponent(Fade_Scene);
 
function OnTriggerStay(col : Collider){
if(col.gameObject.tag == "TheEnd"){
 
end.EndScene();
 
}
}