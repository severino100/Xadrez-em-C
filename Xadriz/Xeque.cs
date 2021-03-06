﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Xadriz
{
    class Xeque
    {
        public bool xequie(Panel partida, Panel chegada, bool tuno, List<Panel> pecas)
        {
            /*
            foreach(Panel simili in pecas)//simula a jogada
            {
                if(simili.Location == chegada.Location)//procura pelo panel de chegada
                {
                    simili.Location = partida.Location;
                    simili.Name = partida.Name;
                    partida.Name = "Vazio";
                 }
            }*/

            foreach (Panel rei in pecas)
            {
                if (rei.Name == "ReiPapel")
                {
                    foreach (Panel procuraPeaoPapel in pecas)
                    {
                        //Peona
                        if (procuraPeaoPapel.Name == "PeaoMadeira")
                        {
                            if (procuraPeaoPapel.Location.Y == rei.Location.Y - 58) // Peao esquerda e direita
                            {
                                if (procuraPeaoPapel.Location.X == rei.Location.X - 58)// Peao esquerda
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoPapel.Location.X == rei.Location.X + 58)// Peao direita
                                {
                                    return true;
                                }
                            }
                        }

                        //-------------------------------------------------------------------------------------------------
                        if (procuraPeaoPapel.Name == "CavaloMadeira")
                        {
                            if (procuraPeaoPapel.Location.Y == rei.Location.Y - 58 - 58) // Cavlo cima direita e esquerda
                            {
                                if (procuraPeaoPapel.Location.X == rei.Location.X - 58)// Cavlo cima direita
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoPapel.Location.X == rei.Location.X + 58)// Cavlo cima esquerda
                                {
                                    return true;
                                }
                            }
                            if (procuraPeaoPapel.Location.Y == rei.Location.Y + 58 + 58) //Cavlo baixo direita e esquerda
                            {
                                if (procuraPeaoPapel.Location.X == rei.Location.X - 58)//Cavlo baixo direita 
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoPapel.Location.X == rei.Location.X + 58)//Cavlo baixo esquerda
                                {
                                    return true;
                                }
                            }
                            //---------------------------------------------------------------------------------------------
                            if (procuraPeaoPapel.Location.X == rei.Location.X - 58 - 58) // Cavlo esquerda CIMA E BAIXO
                            {
                                if (procuraPeaoPapel.Location.Y == rei.Location.Y - 58)// Cavlo esquerda BAIXO
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoPapel.Location.Y == rei.Location.Y + 58)// Cavlo esquerda CIMA
                                {
                                    return true;
                                }
                            }
                            if (procuraPeaoPapel.Location.X == rei.Location.X + 58 + 58) //Cavlo baixo direita e esquerda
                            {
                                if (procuraPeaoPapel.Location.Y == rei.Location.Y - 58)//Cavlo baixo direita 
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoPapel.Location.Y == rei.Location.Y + 58)//Cavlo baixo esquerda
                                {
                                    return true;
                                }
                            }
                            
                        }
                        
                        
                    }

                    //------------------------------------------------------------------------------------------------
                    //VERIFICAR CIMA
                    for (int i = rei.Location.Y; i >= 62; i = i -58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.X == rei.Location.X)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.Y == i)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if(procuraPeaoPapel.Name == "TorreMadeira" || procuraPeaoPapel.Name == "RainhaMadeira")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiPapel" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        i = 0;
                                    }
                                }
                            }
                        }
                    }
                    //--------------------------------------------------------------------------------------------
                    //VERIFICAR BAIXO
                    for (int i = rei.Location.Y; i <= 561; i = i + 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.X == rei.Location.X)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.Y == i)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "TorreMadeira" || procuraPeaoPapel.Name == "RainhaMadeira")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiPapel" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        i = 600;
                                    }
                                }
                            }
                        }
                    }
                    //--------------------------------------------------------------------------------------------
                    //------------------------------------------------------------------------------------------------
                    //VERIFICAR esquerda
                    for (int i = rei.Location.X; i >= 111; i = i - 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.Y == rei.Location.Y)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.X == i)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "TorreMadeira" || procuraPeaoPapel.Name == "RainhaMadeira")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiPapel" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        i = 0;
                                    }
                                }
                            }
                        }
                    }
                    //--------------------------------------------------------------------------------------------
                    //VERIFICAR direita
                    for (int i = rei.Location.X; i <= 517; i = i + 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.Y == rei.Location.Y)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.X == i)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "TorreMadeira" || procuraPeaoPapel.Name == "RainhaMadeira")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiPapel" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        i = 600;
                                    }
                                }
                            }
                        }
                    }

                    //------------------------BISPO----------------------------------------
                    //cima direitra
                    for (int ix = rei.Location.X, iy = rei.Location.Y; ix <= 517 && iy >= 62; ix = ix + 58, iy = iy - 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.Y == iy)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.X == ix)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "BispoMadeira" || procuraPeaoPapel.Name == "RainhaMadeira")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiPapel" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        ix = 600;
                                        iy = 0;
                                    }
                                }
                            }
                        }
                    }
                    //cikma esuqrdxa
                    for (int ix = rei.Location.X, iy = rei.Location.Y; ix >= 111 && iy >= 62; ix = ix - 58, iy = iy - 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.Y == iy)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.X == ix)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "BispoMadeira" || procuraPeaoPapel.Name == "RainhaMadeira")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiPapel" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        ix = 600;
                                        iy = 0;
                                    }
                                }
                            }
                        }

                    }
                    //blaixo direitra
                    for (int ix = rei.Location.X, iy = rei.Location.Y; ix <= 517 && iy <= 561; ix = ix + 58, iy = iy + 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.Y == iy)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.X == ix)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "BispoMadeira" || procuraPeaoPapel.Name == "RainhaMadeira")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiPapel" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        ix = 600;
                                        iy = 0;
                                    }
                                }
                            }
                        }
                    }
                    //baico esuqrdxa
                    for (int ix = rei.Location.X, iy = rei.Location.Y; ix >= 111 && iy <= 561; ix = ix - 58, iy = iy + 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.Y == iy)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.X == ix)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "BispoMadeira" || procuraPeaoPapel.Name == "RainhaMadeira")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiPapel" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        ix = 600;
                                        iy = 0;
                                    }
                                }
                            }
                        }

                    }
                }











                else if (rei.Name == "ReiMadeira")
                {
                    foreach (Panel procuraPeaoMadeira in pecas)
                    {
                        if (procuraPeaoMadeira.Name == "PeaoPapel")
                        {
                            if (procuraPeaoMadeira.Location.Y == rei.Location.Y + 58) // Peao esquerda e direita
                            {
                                if (procuraPeaoMadeira.Location.X == rei.Location.X + 58)// Peao esquerda
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoMadeira.Location.X == rei.Location.X - 58)// Peao direita
                                {
                                    return true;
                                }
                            }
                            //-------------------------------------------------------------------------------------------------

                        }
                        if (procuraPeaoMadeira.Name == "CavaloPapel")
                        {
                            if (procuraPeaoMadeira.Location.Y == rei.Location.Y - 58 - 58) // Cavlo cima direita e esquerda
                            {
                                if (procuraPeaoMadeira.Location.X == rei.Location.X - 58)// Cavlo cima direita
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoMadeira.Location.X == rei.Location.X + 58)// Cavlo cima esquerda
                                {
                                    return true;
                                }
                            }
                            if (procuraPeaoMadeira.Location.Y == rei.Location.Y + 58 + 58) //Cavlo baixo direita e esquerda
                            {
                                if (procuraPeaoMadeira.Location.X == rei.Location.X - 58)//Cavlo baixo direita 
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoMadeira.Location.X == rei.Location.X + 58)//Cavlo baixo esquerda
                                {
                                    return true;
                                }
                            }
                            //---------------------------------------------------------------------------------------------
                            if (procuraPeaoMadeira.Location.X == rei.Location.X - 58 - 58) // Cavlo esquerda CIMA E BAIXO
                            {
                                if (procuraPeaoMadeira.Location.Y == rei.Location.Y - 58)// Cavlo esquerda BAIXO
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoMadeira.Location.Y == rei.Location.Y + 58)// Cavlo esquerda CIMA
                                {
                                    return true;
                                }
                            }
                            if (procuraPeaoMadeira.Location.X == rei.Location.X + 58 + 58) //Cavlo baixo direita e esquerda
                            {
                                if (procuraPeaoMadeira.Location.Y == rei.Location.Y - 58)//Cavlo baixo direita 
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoMadeira.Location.Y == rei.Location.Y + 58)//Cavlo baixo esquerda
                                {
                                    return true;
                                }
                            }
                        }

                    }





                    //------------------------------------------------------------------------------------------------
                    //VERIFICAR CIMA
                    for (int i = rei.Location.Y; i >= 62; i = i - 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.X == rei.Location.X)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.Y == i)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "TorrePapel" || procuraPeaoPapel.Name == "RainhaPapel")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiMadeira" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        i = 0;
                                    }
                                }
                            }
                        }
                    }
                    //--------------------------------------------------------------------------------------------
                    //VERIFICAR BAIXO
                    for (int i = rei.Location.Y; i <= 561; i = i + 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.X == rei.Location.X)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.Y == i)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "TorrePapel" || procuraPeaoPapel.Name == "RainhaPapel")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiMadeira" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        i = 600;
                                    }
                                }
                            }
                        }
                    }
                    //--------------------------------------------------------------------------------------------
                    //------------------------------------------------------------------------------------------------
                    //VERIFICAR esquerda
                    for (int i = rei.Location.X; i >= 111; i = i - 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.Y == rei.Location.Y)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.X == i)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "TorrePapel" || procuraPeaoPapel.Name == "RainhaPapel")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiMadeira" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        i = 0;
                                    }
                                }
                            }
                        }
                    }
                    //--------------------------------------------------------------------------------------------
                    //VERIFICAR direita
                    for (int i = rei.Location.X; i <= 517; i = i + 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.Y == rei.Location.Y)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.X == i)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "TorrePapel" || procuraPeaoPapel.Name == "RainhaPapel")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiMadeira" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        i = 600;
                                    }
                                }
                            }
                        }
                    }

                    //------------------------BISPO----------------------------------------
                    //cima direitra
                    for (int ix = rei.Location.X, iy = rei.Location.Y; ix <= 517 && iy >= 62; ix = ix + 58, iy = iy - 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.Y == iy)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.X == ix)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "BispoPapel" || procuraPeaoPapel.Name == "RainhaPapel")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiMadeira" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        ix = 600;
                                        iy = 0;
                                    }
                                }
                            }
                        }
                    }
                    //cikma esuqrdxa
                    for (int ix = rei.Location.X, iy = rei.Location.Y; ix >= 111 && iy >= 62; ix = ix - 58, iy = iy - 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.Y == iy)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.X == ix)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "BispoPapel" || procuraPeaoPapel.Name == "RainhaPapel")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiMadeira" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        ix = 600;
                                        iy = 0;
                                    }
                                }
                            }
                        }

                    }
                    //blaixo direitra
                    for (int ix = rei.Location.X, iy = rei.Location.Y; ix <= 517 && iy <= 561; ix = ix + 58, iy = iy + 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.Y == iy)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.X == ix)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "BispoPapel" || procuraPeaoPapel.Name == "RainhaPapel")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiMadeira" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        ix = 600;
                                        iy = 0;
                                    }
                                }
                            }
                        }
                    }
                    //baico esuqrdxa
                    for (int ix = rei.Location.X, iy = rei.Location.Y; ix >= 111 && iy <= 561; ix = ix - 58, iy = iy + 58)
                    {
                        foreach (Panel procuraPeaoPapel in pecas)
                        {
                            if (procuraPeaoPapel.Location.Y == iy)//Se esta na mesma linha
                            {
                                if (procuraPeaoPapel.Location.X == ix)//posicao a ser analisada
                                {
                                    //MessageBox.Show(procuraPeaoPapel.Name);
                                    if (procuraPeaoPapel.Name == "BispoPapel" || procuraPeaoPapel.Name == "RainhaPapel")
                                    {
                                        return true;
                                    }
                                    else if (procuraPeaoPapel.Name == "ReiMadeira" || procuraPeaoPapel.Name == "Vazio")
                                    {
                                        //nada!
                                    }
                                    else
                                    {
                                        ix = 600;
                                        iy = 0;
                                    }
                                }
                            }
                        }

                    }
                }

            }
            return false;
        }
    }
}
