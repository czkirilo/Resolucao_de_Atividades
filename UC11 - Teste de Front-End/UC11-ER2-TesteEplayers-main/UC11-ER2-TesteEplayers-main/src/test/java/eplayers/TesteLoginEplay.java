package eplayers;

import java.util.concurrent.TimeUnit;

import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class TesteLoginEplay {
	private WebDriver driver;
	
	@Before
	public void abrirNavegador() {
		System.setProperty("webdriver.chrome.driver", "C:\\Arquivos de Programas\\chromedriver\\chromedriver.exe");
		driver = new ChromeDriver();
		driver.get("http://localhost:4200/login");

	}
	
	@Test
	public void testeNavegador() {
		driver.manage().timeouts().implicitlyWait(3, TimeUnit.SECONDS);
		
		WebElement inputEmail = driver.findElement(By.id("email"));
		WebElement inputSenha = driver.findElement(By.id("senha"));
		WebElement botaoLogin = driver.findElement(By.id("botao-enviar"));
		
		String[] listaSenhas = {"senhaum", "outrasenha", "senhaerrada", "paredecomerbesteira"};
		
		for(int tentativas = 0; tentativas < listaSenhas.length; tentativas++) {
			
			try {
			inputEmail.clear();
			inputSenha.clear();
			
			inputEmail.sendKeys("caique@email.com");
			inputSenha.sendKeys(listaSenhas[tentativas]);
			botaoLogin.click();
			
			Thread.sleep(3000);
			
		}catch (InterruptedException e) {
			e.printStackTrace();
		}
		}
	}
}
	
