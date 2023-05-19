import { Pipe, PipeTransform } from "@angular/core";

@Pipe({
    name: 'SelectS'
})

export class SelectSPipe implements PipeTransform {
    transform(list: any[], id: string): any[] {
        if (!id) {
          return list; 
        }
        
        return list.filter(student => student.ID.toLowerCase().includes(id.toLowerCase()));
      }
}
