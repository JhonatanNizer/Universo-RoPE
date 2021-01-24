using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasesControladora : MonoBehaviour {
    #region Varaveis
    public Fase mundo1Fase1 = new Fase();
    public Fase mundo1Fase2 = new Fase();
    public Fase mundo1Fase3 = new Fase();

    public Fase mundo2Fase1 = new Fase();
    public Fase mundo2Fase2 = new Fase();
    public Fase mundo2Fase3 = new Fase();

    public Fase mundo3Fase1 = new Fase();
    public Fase mundo3Fase2 = new Fase();
    public Fase mundo3Fase3 = new Fase();
    #endregion

    public void SalvaDados() {
        PlayerPrefs.SetFloat("m1f1_pontuacao", 0);
        PlayerPrefs.SetInt("m1f1_finalizada", 0);
        PlayerPrefs.SetFloat("m1f2_pontuacao", 0);
        PlayerPrefs.SetInt("m1f2_finalizada", 0);
        PlayerPrefs.SetFloat("m1f3_pontuacao", 0);
        PlayerPrefs.SetInt("m1f3_finalizada", 0);

        PlayerPrefs.SetFloat("m2f1_pontuacao", 0);
        PlayerPrefs.SetInt("m2f1_finalizada", 0);
        PlayerPrefs.SetFloat("m2f2_pontuacao", 0);
        PlayerPrefs.SetInt("m2f2_finalizada", 0);
        PlayerPrefs.SetFloat("m2f3_pontuacao", 0);
        PlayerPrefs.SetInt("m2f3_finalizada", 0);

        PlayerPrefs.SetFloat("m3f1_pontuacao", 0);
        PlayerPrefs.SetInt("m3f1_finalizada", 0);
        PlayerPrefs.SetFloat("m3f2_pontuacao", 0);
        PlayerPrefs.SetInt("m3f2_finalizada", 0);
        PlayerPrefs.SetFloat("m3f3_pontuacao", 0);
        PlayerPrefs.SetInt("m3f3_finalizada", 0);
    }
    public void LoadDados() {
        mundo1Fase1.Pontuacao = PlayerPrefs.GetFloat("m1f1_pontuacao");
        mundo1Fase1.Finalizada = PlayerPrefs.GetInt("m1f1_finalizada");
        mundo1Fase2.Pontuacao = PlayerPrefs.GetFloat("m1f2_pontuacao");
        mundo1Fase2.Finalizada = PlayerPrefs.GetInt("m1f2_finalizada");
        mundo1Fase3.Pontuacao = PlayerPrefs.GetFloat("m1f3_pontuacao");
        mundo1Fase3.Finalizada = PlayerPrefs.GetInt("m1f3_finalizada");

        mundo2Fase1.Pontuacao = PlayerPrefs.GetFloat("m2f1_pontuacao");
        mundo2Fase1.Finalizada = PlayerPrefs.GetInt("m2f1_finalizada");
        mundo2Fase2.Pontuacao = PlayerPrefs.GetFloat("m2f2_pontuacao");
        mundo2Fase2.Finalizada = PlayerPrefs.GetInt("m2f2_finalizada");
        mundo2Fase3.Pontuacao = PlayerPrefs.GetFloat("m2f3_pontuacao");
        mundo2Fase3.Finalizada = PlayerPrefs.GetInt("m2f3_finalizada");

        mundo3Fase1.Pontuacao = PlayerPrefs.GetFloat("m3f1_pontuacao");
        mundo3Fase1.Finalizada = PlayerPrefs.GetInt("m3f1_finalizada");
        mundo3Fase2.Pontuacao = PlayerPrefs.GetFloat("m3f2_pontuacao");
        mundo3Fase2.Finalizada = PlayerPrefs.GetInt("m3f2_finalizada");
        mundo3Fase3.Pontuacao = PlayerPrefs.GetFloat("m3f3_pontuacao");
        mundo3Fase3.Finalizada = PlayerPrefs.GetInt("m3f3_finalizada");
    }

}

public class Fase {
    private int finalizada;
    private float pontuacao;

    public int Finalizada {
        get { return finalizada; }
        set { finalizada = value; }
    }
    public float Pontuacao {
        get { return pontuacao; }
        set { pontuacao = value; }
    }
}
