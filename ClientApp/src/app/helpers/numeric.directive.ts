import { Directive, ElementRef, HostListener, Injectable, Input } from "@angular/core";

@Injectable()

@Directive({
  selector: "[numeric]"
})

export class NumericDirective {
  ValidarCamposNulosOuVazios(valores: string[]) {
    for (var i = 0; i < valores.length; i++) {
      if (valores[i] == null || valores[i].toString().trim() == "") {
        alert("Por favor, preencha os campos corretamente!");
        return false;
      }
    }

    return true;
  }

  //Valida se contém somente números e positivos
  ValidarNumeros(valores: string[]) {
    let regexCurrency = /^[0-9]+\.[0-9]+$/;
    let regexCurrencyInt = /^[0-9]+$/;
    //let regex = /^[0-9][0-9,]*[0-9]\.?[0-9]{0,2}$/;
    let isValidated;
    for (var i = 0; i < valores.length; i++) {

      isValidated = regexCurrency.test(valores[i]) == true || regexCurrencyInt.test(valores[i]) == true;

      if (!isValidated) {
        alert("formato do valor inválido: informe apenas números (positivos)")
        return false;
      }      
    }

    if (Number(valores[1]) <= 1 || Number(valores[1]) > 360) {
      alert("por favor, informe um valor positivo => Mínimo: 2. Máximo: 360.")
      return false;
    }

    return true;
  }

}
