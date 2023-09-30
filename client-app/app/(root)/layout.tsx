import { ClerkProvider } from '@clerk/nextjs'
import '../globals.css'
import type { Metadata } from 'next'
import { Inter } from 'next/font/google'
import { Nav } from '../../components/shared/Nav'
import { LeftSideBar } from '../../components/shared/LeftSideBar'
import { RightSideBar } from '../../components/shared/RightSideBar'
import { GeneralInfo } from '../../components/shared/GeneralInfo'

const inter = Inter({ subsets: ['latin'] })

export const metadata: Metadata = {
    title: 'Create Next App',
    description: 'Generated by create next app',
}

export default function RootLayout({
    children,
}: {
    children: React.ReactNode
}) {
    return (
        <ClerkProvider>
            <html lang="en">
                <body className={inter.className}>
                    <Nav/>
                    <main className="flex">
                        <LeftSideBar />
                        <section className="main-container">
                            <div className="w-full max-w-4xl">
                                {children}
                            </div>
                        </section>
                        <RightSideBar/>
                    </main>
                    <GeneralInfo/>
                </body>
            </html>
        </ClerkProvider>
    )
}
