/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

import dao.ArticleDAO;
import entite.Article;
import java.util.UUID;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author admin
 */

// notre service gere l'ajout et la suppression des articles 

@WebService(serviceName = "GestionArticleWebService")
public class GestionArticleWebService {

    // methode pour ajouter une article
    
    @WebMethod(operationName = "AjouterArticle")
    public boolean add(@WebParam(name = "article") Article article) {
       
        ArticleDAO dao = new ArticleDAO();
        article.setId(UUID.randomUUID().toString()); 
        boolean resultat = dao.create(article);
        return resultat;
        
    }
    
    // methode pour supprimer un article
    
    @WebMethod(operationName = "SupprimerArticle")
    public boolean delete(@WebParam(name = "titre") String titre) {
       
        ArticleDAO dao = new ArticleDAO();
         
        boolean resultat = dao.delete(titre);
        return resultat;
        
    }
}
