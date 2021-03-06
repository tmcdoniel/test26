///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest26
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest26Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("6a70261e-0384-40b2-aed9-27af18a69284")]
    public partial class MyTest26Repository : RepoGenBaseFolder
    {
        static MyTest26Repository instance = new MyTest26Repository();
        MyTest26RepositoryFolders.RxMainFrameAppFolder _rxmainframe;
        RepoItemInfo _btnaddpersonInfo;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest26Repository element repository.
        /// </summary>
        [RepositoryFolder("6a70261e-0384-40b2-aed9-27af18a69284")]
        public static MyTest26Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest26Repository() 
            : base("MyTest26Repository", "/", null, 0, false, "6a70261e-0384-40b2-aed9-27af18a69284", ".\\RepositoryImages\\MyTest26Repository6a70261e.rximgres")
        {
            _rxmainframe = new MyTest26RepositoryFolders.RxMainFrameAppFolder(this);
            _btnaddpersonInfo = new RepoItemInfo(this, "BtnAddPerson", "/form[@controlname='RxMainFrame']/?/?/tabpage[@controlname='RxTabStandard']/button[@controlname='btnAddPerson']", 1000, null, "d8dfe989-4e1b-4d6e-bc97-5a853f59d7bc");
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("6a70261e-0384-40b2-aed9-27af18a69284")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The BtnAddPerson item.
        /// </summary>
        [RepositoryItem("d8dfe989-4e1b-4d6e-bc97-5a853f59d7bc")]
        public virtual Ranorex.Button BtnAddPerson
        {
            get
            {
                 return _btnaddpersonInfo.CreateAdapter<Ranorex.Button>(true);
            }
        }

        /// <summary>
        /// The BtnAddPerson item info.
        /// </summary>
        [RepositoryItemInfo("d8dfe989-4e1b-4d6e-bc97-5a853f59d7bc")]
        public virtual RepoItemInfo BtnAddPersonInfo
        {
            get
            {
                return _btnaddpersonInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("8d5c711d-cf57-48eb-a20b-910b363dc7e9")]
        public virtual MyTest26RepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest26RepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("8d5c711d-cf57-48eb-a20b-910b363dc7e9")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            MyTest26RepositoryFolders.RxTabStandardFolder _rxtabstandard;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@controlname='RxMainFrame']", parentFolder, 30000, null, true, "8d5c711d-cf57-48eb-a20b-910b363dc7e9", "")
            {
                _rxtabstandard = new MyTest26RepositoryFolders.RxTabStandardFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("8d5c711d-cf57-48eb-a20b-910b363dc7e9")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("8d5c711d-cf57-48eb-a20b-910b363dc7e9")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The RxTabStandard folder.
            /// </summary>
            [RepositoryFolder("22142911-e784-4d45-8b79-bdccdf613ad9")]
            public virtual MyTest26RepositoryFolders.RxTabStandardFolder RxTabStandard
            {
                get { return _rxtabstandard; }
            }
        }

        /// <summary>
        /// The RxTabStandardFolder folder.
        /// </summary>
        [RepositoryFolder("22142911-e784-4d45-8b79-bdccdf613ad9")]
        public partial class RxTabStandardFolder : RepoGenBaseFolder
        {
            RepoItemInfo _firstnameInfo;
            RepoItemInfo _lastnameInfo;
            RepoItemInfo _ageInfo;
            RepoItemInfo _openInfo;
            RepoItemInfo _text1001Info;

            /// <summary>
            /// Creates a new RxTabStandard  folder.
            /// </summary>
            public RxTabStandardFolder(RepoGenBaseFolder parentFolder) :
                    base("RxTabStandard", "?/?/tabpage[@controlname='RxTabStandard']", parentFolder, 30000, null, false, "22142911-e784-4d45-8b79-bdccdf613ad9", "")
            {
                _firstnameInfo = new RepoItemInfo(this, "FirstName", "?/?/text[@accessiblename='First name']", "", 1000, null, "9cad9dcb-55da-4a0a-9849-5f36d35b3e7c");
                _lastnameInfo = new RepoItemInfo(this, "LastName", "?/?/text[@accessiblename='Last name']", "", 1000, null, "f574bc17-c29c-4c99-a83a-e6794b9a90f2");
                _ageInfo = new RepoItemInfo(this, "Age", "?/?/text[@controlname='upDownEdit']", "", 1000, null, "4e9e1080-b003-4fb6-a74e-3ca6bc17d236");
                _openInfo = new RepoItemInfo(this, "Open", "?/?/button[@accessiblename='Open']", "", 1000, null, "516f9254-2983-4c02-95e0-ccb70e50c1cd");
                _text1001Info = new RepoItemInfo(this, "Text1001", "?/?/text[@controlid='1001']", "", 1000, null, "02b7ff0a-cecc-4f04-a2c3-d0cb8cec8105");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("22142911-e784-4d45-8b79-bdccdf613ad9")]
            public virtual Ranorex.TabPage Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("22142911-e784-4d45-8b79-bdccdf613ad9")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The FirstName item.
            /// </summary>
            [RepositoryItem("9cad9dcb-55da-4a0a-9849-5f36d35b3e7c")]
            public virtual Ranorex.Text FirstName
            {
                get
                {
                    return _firstnameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The FirstName item info.
            /// </summary>
            [RepositoryItemInfo("9cad9dcb-55da-4a0a-9849-5f36d35b3e7c")]
            public virtual RepoItemInfo FirstNameInfo
            {
                get
                {
                    return _firstnameInfo;
                }
            }

            /// <summary>
            /// The LastName item.
            /// </summary>
            [RepositoryItem("f574bc17-c29c-4c99-a83a-e6794b9a90f2")]
            public virtual Ranorex.Text LastName
            {
                get
                {
                    return _lastnameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LastName item info.
            /// </summary>
            [RepositoryItemInfo("f574bc17-c29c-4c99-a83a-e6794b9a90f2")]
            public virtual RepoItemInfo LastNameInfo
            {
                get
                {
                    return _lastnameInfo;
                }
            }

            /// <summary>
            /// The Age item.
            /// </summary>
            [RepositoryItem("4e9e1080-b003-4fb6-a74e-3ca6bc17d236")]
            public virtual Ranorex.Text Age
            {
                get
                {
                    return _ageInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Age item info.
            /// </summary>
            [RepositoryItemInfo("4e9e1080-b003-4fb6-a74e-3ca6bc17d236")]
            public virtual RepoItemInfo AgeInfo
            {
                get
                {
                    return _ageInfo;
                }
            }

            /// <summary>
            /// The Open item.
            /// </summary>
            [RepositoryItem("516f9254-2983-4c02-95e0-ccb70e50c1cd")]
            public virtual Ranorex.Button Open
            {
                get
                {
                    return _openInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Open item info.
            /// </summary>
            [RepositoryItemInfo("516f9254-2983-4c02-95e0-ccb70e50c1cd")]
            public virtual RepoItemInfo OpenInfo
            {
                get
                {
                    return _openInfo;
                }
            }

            /// <summary>
            /// The Text1001 item.
            /// </summary>
            [RepositoryItem("02b7ff0a-cecc-4f04-a2c3-d0cb8cec8105")]
            public virtual Ranorex.Text Text1001
            {
                get
                {
                    return _text1001Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text1001 item info.
            /// </summary>
            [RepositoryItemInfo("02b7ff0a-cecc-4f04-a2c3-d0cb8cec8105")]
            public virtual RepoItemInfo Text1001Info
            {
                get
                {
                    return _text1001Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
