using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UiControladora : MonoBehaviour {

    #region Variáveis
    public bool Mover;
    public bool EstaMovendo = false;
    public bool IsMovimentoFinalizado;
    public bool Pause;
    public bool IsProximoMovimentoFrenteValido;
    public bool IsProxiMovimentoAtrasValido;
    public float TempoPausaEntreMovimentos;
    public float Set_TempoPausaEntreMovimentos;
    public float velocidade;
    public float progressoRotacao;
    public float tempoExecucaoComando;
    public float tempoAtual;
    public int comandosExecutados;
    public int comandoAtual;
    public int indexComandoAtual;
    public GameObject RoPE;
    public GameObject botaoFrente;
    public GameObject botaoDireita;
    public GameObject botaoBaixo;
    public GameObject botaoEsquerda;
    public Transform PontoA;
    public Transform PontoB;
    public Vector3 PosicaoInicialRoPE;
    public Vector3 PosicaoInicialPontoA;
    public Vector3 PosicaoInicialPontoB;
    public Quaternion quarterionRotacaoInicial;
    public Quaternion quarterionRotacaoFinalDireita;
    public Quaternion quarterionRotacaoFinalEsquerda;
    public TesteColisao PodeMoverFrente;
    public TesteColisao PodeMoverAtras;
    public GameObject iconeBrancoPiscando;
    public Transform[] posicoes;
    public List<int> ListaComandos = new List<int>();
    public List<GameObject> ListaComandossGrafico = new List<GameObject>();

    #endregion

    public void Update() {
        IsProximoMovimentoValido(1);
        IsProximoMovimentoValido(3);
        if (Mover) {
             ExecutaComandos();
        }
        if (Pause) {
            TempoPausaEntreMovimentos += Time.deltaTime;
        }
    }
    private void ExecutaComandos() {
        //Frente
        if (comandoAtual == 1) {
            IsProximoMovimentoFrenteValido = IsProximoMovimentoValido(1);
            if (IsProximoMovimentoFrenteValido) {
                MoveFrente();
            } else {
                PulaMovimento();
            }
        }
        //Direita
        if (comandoAtual == 2) {
            GiraDireita();
        }
        //Atras
        if (comandoAtual == 3) {
            IsProxiMovimentoAtrasValido = IsProximoMovimentoValido(3);
            if (IsProxiMovimentoAtrasValido) {
                MoveAtras();
            } else {
                PulaMovimento();
            }
        }
        //Esquerda
        if (comandoAtual == 4) {
            GiraEsquerda();
        }
    }
    public void ComandoClick(int comando) {
        if (!Mover) {
            InsereComando(comando);
        }
    }
    public void AcaoClick() {
        if(ListaComandos.Count != 0 && !Mover) {
            EstaMovendo = true;
            UpdateRoPEPositions();
            progressoRotacao = 0;
            indexComandoAtual = 0;
            comandoAtual = ListaComandos[indexComandoAtual];
            Mover = true;
        }
    }

    
    private void InsereComando(int comando) {
        iconeBrancoPiscando.SetActive(true);
        if (ListaComandos.Count < posicoes.Length) {
            ListaComandos.Add(comando);
            
            if (comando == 1) {
                ListaComandossGrafico.Add(botaoFrente);
            } else if (comando == 2) {
                ListaComandossGrafico.Add(botaoDireita);
            } else if (comando == 3) {
                ListaComandossGrafico.Add(botaoBaixo);
            } else if (comando == 4) {
                ListaComandossGrafico.Add(botaoEsquerda);
            }
            Instantiate(ListaComandossGrafico[ListaComandos.Count - 1], posicoes[ListaComandos.Count - 1]);
        }
    }
    private void ProximoMovimento() {
        tempoAtual = 0;
        comandosExecutados++;
        if(comandosExecutados != ListaComandos.Count) {
            UpdateRoPEPositions();
            indexComandoAtual++;
            comandoAtual = ListaComandos[indexComandoAtual];
            Mover = true;
        } else {
            ResetVariaveis();
        }
    }
    private void PulaMovimento() {
        tempoAtual = 0;
        comandosExecutados++;
        if (comandosExecutados != ListaComandos.Count) {
            UpdateRoPEPositions();
            indexComandoAtual++;
            comandoAtual = ListaComandos[indexComandoAtual];
            Mover = true;

        } else {
            ResetVariaveis();
        }
    }
    private bool IsProximoMovimentoValido(int comando) {
        if(comando == 1) {
            if (PodeMoverFrente.EstaColidindo && IsMovimentoFinalizado) {
                IsProximoMovimentoFrenteValido = false;
                return false;
            } else {
                IsProximoMovimentoFrenteValido = true;
            }
        } else if(comando == 3){
            if (PodeMoverAtras.EstaColidindo && IsMovimentoFinalizado) {
                IsProxiMovimentoAtrasValido = false;
                return false;
            } else {
                IsProxiMovimentoAtrasValido = true;
            }
        }
        return true;
    }
    private void MoveFrente() {
        IsMovimentoFinalizado = false;
        tempoAtual += Time.deltaTime;
        if (tempoAtual >= tempoExecucaoComando) {
            tempoAtual = tempoExecucaoComando;
        }
        float tempo = tempoAtual / tempoExecucaoComando;
        //RoPE.transform.position = Vector3.Lerp(PosicaoInicialRoPE, PosicaoInicialPontoA, tempo * velocidade);
        RoPE.transform.position = Vector3.MoveTowards(PosicaoInicialRoPE, PosicaoInicialPontoA, tempo * velocidade);

        if (RoPE.transform.position == PosicaoInicialPontoA) {
            IsMovimentoFinalizado = true;
            Pause = true;
            if (TempoPausaEntreMovimentos > Set_TempoPausaEntreMovimentos) {
                TempoPausaEntreMovimentos = 0;
                Pause = false;
                ProximoMovimento();
            }
        }
    }
    private void MoveAtras() {
        IsMovimentoFinalizado = false;
        tempoAtual += Time.deltaTime;
        if (tempoAtual >= tempoExecucaoComando) {
            tempoAtual = tempoExecucaoComando;
        }
        float tempo = tempoAtual / tempoExecucaoComando;
        //RoPE.transform.position = Vector3.Lerp(PosicaoInicialRoPE, PosicaoInicialPontoB, tempo * velocidade);
        RoPE.transform.position = Vector3.MoveTowards(PosicaoInicialRoPE, PosicaoInicialPontoB, tempo * velocidade);

        if (RoPE.transform.position == PosicaoInicialPontoB) {
            IsMovimentoFinalizado = true;
            Pause = true;
            if (TempoPausaEntreMovimentos > Set_TempoPausaEntreMovimentos) {
                TempoPausaEntreMovimentos = 0;
                Pause = false;
                ProximoMovimento();
            }
        }
    }
    private void GiraDireita() {
        if (progressoRotacao < 1 && progressoRotacao >= 0) {
            progressoRotacao += Time.deltaTime * velocidade/3;
            RoPE.transform.rotation = Quaternion.Lerp(quarterionRotacaoInicial, quarterionRotacaoFinalDireita, progressoRotacao);
        } else {
            Mover = false;
            progressoRotacao = 0;
            ProximoMovimento();
        }
    }
    private void GiraEsquerda() {
        if (progressoRotacao < 1 && progressoRotacao >= 0) {
            progressoRotacao += Time.deltaTime * velocidade / 3;
            RoPE.transform.rotation = Quaternion.Lerp(quarterionRotacaoInicial, quarterionRotacaoFinalEsquerda, progressoRotacao);
        } else {
            Mover = false;
            progressoRotacao = 0;
            ProximoMovimento();
        }
    }
    private void ResetVariaveis() {
        EstaMovendo = false;
        Mover = false;
        ListaComandos.Clear();
        ListaComandossGrafico.Clear();
        tempoAtual = 0;
        comandosExecutados = 0;
        comandoAtual = 0;
        indexComandoAtual = 0;
        progressoRotacao = 0;
        UpdateRoPEPositions();
    }
    private void UpdateRoPEPositions() {
        PosicaoInicialRoPE = RoPE.transform.position;
        PosicaoInicialPontoA = PontoA.transform.position;
        PosicaoInicialPontoB = PontoB.transform.position;

        quarterionRotacaoInicial = RoPE.transform.rotation;
        quarterionRotacaoFinalDireita = Quaternion.Euler(RoPE.transform.rotation.eulerAngles.x, RoPE.transform.rotation.eulerAngles.y + 90, RoPE.transform.rotation.eulerAngles.z);
        quarterionRotacaoFinalEsquerda = Quaternion.Euler(RoPE.transform.rotation.eulerAngles.x, RoPE.transform.rotation.eulerAngles.y - 90, RoPE.transform.rotation.eulerAngles.z);
    }

}
