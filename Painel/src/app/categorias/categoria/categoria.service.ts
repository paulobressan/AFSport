import { Injectable } from '@angular/core';
import { HttpClient } from 'selenium-webdriver/http';

@Injectable()
export class CategoriaService {
    constructor(private http : HttpClient){      
    }

    listarCategorias(){
        
    }
}