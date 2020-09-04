/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import entite.Article;
import java.io.ByteArrayInputStream;
import java.io.InputStream;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import jdbc.DataBase;

/**
 *
 * @author admin
 */

// ArticleDAO sert d'une cache d'acces aux donnees
public class ArticleDAO {
    
    public boolean create (Article article)
    {
        Connection connexion = DataBase.getInstance();
        try {
            PreparedStatement stm = connexion.prepareStatement("INSERT INTO article (ID,TITRE,TEXTE,IMAGE) VALUES (?,?,?,?)");
            
            stm.setString(1, article.getId());
            stm.setString(2, article.getTitle());
            stm.setString(3, article.getTexte());
            
            InputStream targetStream = new ByteArrayInputStream(article.getImage());
            stm.setBinaryStream(4, targetStream);
           
                int n = stm.executeUpdate();
        if (n>0) return true;
        } catch (SQLException ex) {
            Logger.getLogger(ArticleDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
    
        return false;
    }
    
    
    public boolean delete(String txt)
    {
        Connection connexion = DataBase.getInstance();
        try {
            PreparedStatement stm = connexion.prepareStatement("DELETE FROM article where TITRE=?");
            stm.setString(1, txt);
             int n = stm.executeUpdate();
        if (n>0) return true;
        } catch (SQLException ex) {
            Logger.getLogger(ArticleDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
    
        return false;
    }
}
