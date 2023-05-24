import { Component } from '@angular/core';

@Component({
  selector: 'app-click-render',
  templateUrl: './click-render.component.html',
  styleUrls: ['./click-render.component.css']
})
export class ClickRenderComponent {
  WordRender : string = "Default Word";
  Toggle(){
    if(this.WordRender === "Default Word"){
      this.WordRender = "Changed Word"
    }
    else if(this.WordRender === "Changed Word"){
      this.WordRender = "Default Word"
    }
  }
}
